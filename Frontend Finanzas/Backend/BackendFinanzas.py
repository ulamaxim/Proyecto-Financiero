#===============================================================================================
# Código para leer y procesar un archivo XLSX de transacciones financieras del banco Santander.
# y enviar los datos a SQL Server para usarlos en una aplicacion posteriormente
# Creado por: [Maksim Iulamanov]
# Fecha de creacion: [2026-07-13]
#===============================================================================================

# Importamos las librerías necesarias
import os
import pyodbc
import pandas as pd
import warnings
import sys

# Ignoramos las advertencias no importantes
warnings.filterwarnings("ignore", category=UserWarning, module="openpyxl")

#==========================
# Importacion de datos
#==========================

# Evaluamos si se ejecuta como binario compilado por PyInstaller o como script .py
if getattr(sys, 'frozen', False):
    carpeta_base = os.path.dirname(sys.executable)
else:
    carpeta_base = os.path.dirname(os.path.abspath(__file__))

archivoExcel = os.path.abspath(os.path.join(carpeta_base, "..", "Datos Financieros", "TransactionExcelFile.xlsx"))

print(f"Ruta calculada por Python: {archivoExcel}\n")

# Leemos el archivo saltando las 7 filas que contienen informacion irrelevante
try:
    df = pd.read_excel(archivoExcel, skiprows=7)
    print("¡Archivo leído con éxito!")
except Exception as e:
    print(f"Error al abrir el archivo: {e}")
    sys.exit(1)  # Interrumpe la ejecución para evitar NameError en las líneas siguientes

#=============================================
# Depuracion y cambios de datos
#=============================================

# Cambiamos los nombres de columnas
df.columns = ['Fecha_Operacion', 'Fecha_Valor', 'Concepto', 'Importe', 'Saldo', 'Divisa']

# Creamos funcion para formatear valores numericos de columnas Importe y Saldo
def limpiar_dinero_excel(columna):
    if pd.api.types.is_numeric_dtype(columna):
        return columna
    contenido = columna.astype(str).str.strip()
    contenido = contenido.str.replace(r'[^\d,.-]', '', regex=True)
    contenido = contenido.str.replace('.', '', regex=False)
    contenido = contenido.str.replace(',', '.', regex=False)
    return pd.to_numeric(contenido, errors='coerce')

if sys.stdout.encoding != 'utf-8':
    sys.stdout.reconfigure(encoding='utf-8')
if sys.stderr.encoding != 'utf-8':
    sys.stderr.reconfigure(encoding='utf-8')

# Aplicamos la funcion a las dichas columnas
df['Importe'] = limpiar_dinero_excel(df['Importe'])
df['Saldo'] = limpiar_dinero_excel(df['Saldo'])
    
# Formteamos fechas
df['Fecha_Operacion'] = pd.to_datetime(df['Fecha_Operacion'], dayfirst=True, errors='coerce')
df['Fecha_Valor'] = pd.to_datetime(df['Fecha_Valor'], dayfirst=True, errors='coerce')
    
# Limpiamos espacios vacios en Concepto
df['Concepto'] = df['Concepto'].astype(str).str.strip()
df['Concepto'] = df['Concepto'].str.replace(r'TRANSACCION\s+CONTACTLESS\s+EN', '', regex=True, case=False).str.strip()
df['Concepto'] = df['Concepto'].str.replace(r'COMPRA', '', regex=True, case=False).str.strip()

# Le decimos a Python el formato exacto de fechas para evitar posibles errores
df['Fecha_Operacion'] = pd.to_datetime(df['Fecha_Operacion'], dayfirst=True, errors='coerce')
df['Fecha_Valor'] = pd.to_datetime(df['Fecha_Valor'], dayfirst=True, errors='coerce')

# Creamos las reglas que se aplicaran a los datos de la columna Concepto para sacar la categoria
REGLAS_CATEGORIAS = {
    # === INGRESOS Y DINERO EN EFECTIVO ===
    'Nomina': ['NOMINA', 'ORDENANTE', 'HABERES', 'SALARIO'],
    'Efectivo': ['CAJERO', 'RETIRADA', 'EFECTIVO', 'INGRESO EN EFECTIVO', 'DISPENSACION'],
    
    # === COMPRAS Y MODA (No supermercados) ===
    'Compras y Moda': ['PRIMARK', 'ZARA', 'H&M', 'MANGO', 'DECATHLON', 'IKEA', 'LEFTHANDES', 'CORTE INGLES', 'SHEIN', 'TEMU', 'AMAZON'],
    
    # === ALIMENTACIÓN Y SUPERMERCADO ===
    'Supermercado': ['ALIMERKA', 'MERCADONA', 'CARREFOUR', 'DIA', 'ALCAMPO', 'LIDL', 'EROSKI', 'CONSUM', 'MASYMAS', 'FRUTERIA', 'PANADERIA'],
    
    # === COMER Y BEBER ===
    'Restauracion': ['CAFE', 'BAR', 'RESTAURANTE', 'BURGER KING', 'MCDONALD', 'TELEPIZZA', 'DOMINOS', 'STARBUCKS', 'TABERNA', 'PUB', 'FOOD PLANET'],
    
    # === OCIO Y JUEGOS ===
    'Entretenimiento': ['STEAM', 'NETFLIX', 'SPOTIFY', 'NINTENDO', 'PLAYSTATION', 'PLAY STATION', 'XBOX', 'CINE', 'YOUTUBEPREMIUM'],
    
    # === SALUD Y BIENESTAR ===
    'Salud': ['FARMACIA', 'DENTISTA', 'CLINICA', 'MEDICO', 'OPTICA', 'SANIEDAD', 'HOSPITAL'],
    
    # === VIAJES Y MOVILIDAD ===
    'Transporte': ['GASOLINERA', 'REPSOL', 'CEPSA', 'BP', 'ALSA', 'RENFE', 'UBER', 'CABIFY', 'BOLT', 'PEAJE', 'PARKING', 'ESTACIONAMIENTO'],
    
    # === SERVICIOS Y SUSCRIPCIONES ===
    'Suscripciones': ['AMAZON PRIME', 'ICLOUD', 'MICROSOFT', 'ADOBE', 'GOOGLE STORAGE', 'CHATGPT', 'OPENAI'],
    
    # === GASTOS DEL HOGAR / RECURRENTES ===
    'Hogar y Facturas': ['TELEFONICA', 'MOVISTAR', 'VODAFONE', 'ORANGE', 'DIGI', 'IBERDROLA', 'ENDESA', 'ALSA AGUA', 'COMUNIDAD', 'ALQUILER']
}

# Creamos funcion que itere por los datos de la columna y los compare con las reglas de categorias
def asignar_categoria(concepto):
    concepto_upper = str(concepto).upper()
    
    # Recorremos nuestro diccionario de reglas
    for categoria, palabras_clave in REGLAS_CATEGORIAS.items():
        for palabra in palabras_clave:
            if palabra in concepto_upper:
                return categoria # Si encuentra la palabra, devuelve la categoría inmediatamente
                
    return 'Otros' # Categoría por defecto si no coincide con ninguna regla

# Aplicamos la funcion a la columna Concepto
df['Categoria'] = df['Concepto'].apply(asignar_categoria)

#=======================================================
# Conexion y carga de datos obtenidos a la base de datos
#=======================================================

# === CONFIGURACIÓN DE LA CONEXIÓN ===
conn_str = (
    "DRIVER={ODBC Driver 17 for SQL Server};"
    "SERVER=.\SQLEXPRESS;" 
    "DATABASE=FinanzasDB;"
    "Trusted_Connection=yes;"
)

try:
    print("\n[SQL Server] Intentando conectar a la base de datos...")
    conn = pyodbc.connect(conn_str)
    cursor = conn.cursor()
    print("[SQL Server] Conexión establecida con éxito.")
    
    # Vaciamos la tabla por completo antes de insertar el Excel actualizado
    print("[SQL Server] Limpiando datos antiguos de la tabla...")
    cursor.execute("TRUNCATE TABLE Transacciones")
    
    print("[SQL Server] Guardando las nuevas transacciones...")
    for index, fila in df.iterrows():
        cursor.execute("""
            INSERT INTO Transacciones (
                Fecha_Operacion, 
                Fecha_Valor, 
                Concepto,
                Categoria,
                Importe, 
                Saldo, 
                Divisa
            )
            VALUES (?, ?, ?, ?, ?, ?, ?)
        """, 
        fila['Fecha_Operacion'].to_pydatetime() if pd.notnull(fila['Fecha_Operacion']) else None,
        fila['Fecha_Valor'].to_pydatetime() if pd.notnull(fila['Fecha_Valor']) else None,
        fila['Concepto'],
        fila['Categoria'],
        float(fila['Importe']) if pd.notnull(fila['Importe']) else 0.0,
        float(fila['Saldo']) if pd.notnull(fila['Saldo']) else 0.0,
        fila['Divisa']
        )
    
    # Confirmamos todos los cambios (el Truncate y los nuevos Inserts)
    conn.commit()
    
    cursor.close()
    conn.close()
    print(f"\nTabla actualizada con exito. {len(df)} transacciones cargadas.")

except Exception as e:
    print(f"\n[ERROR SQL Server] Fallo en la actualización: {e}")