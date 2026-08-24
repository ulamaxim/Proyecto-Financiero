#===============================================================================================
# Código para leer y procesar un archivo XLSX de transacciones financieras del banco Santander.
# y enviar los datos a SQL Server para usarlos en una aplicacion posteriormente
# Creado por: [Maksim Iulamanov]
# Fecha de creacion: [2026-07-13]
#===============================================================================================

import os
import sys
import warnings
import pandas as pd
import pyodbc

warnings.filterwarnings("ignore", category=UserWarning, module="openpyxl")

# Reconfiguración de encodado UTF-8
if sys.stdout.encoding != 'utf-8':
    sys.stdout.reconfigure(encoding='utf-8')
if sys.stderr.encoding != 'utf-8':
    sys.stderr.reconfigure(encoding='utf-8')

# 1. Obtenemos el directorio físico donde reside el binario ejecutable o el script
if getattr(sys, 'frozen', False):
    directorio_actual = os.path.dirname(sys.executable) # bin/Debug/Backend
else:
    directorio_actual = os.path.dirname(os.path.abspath(__file__))

# 2. Ruta directa fijada a FrontendFinanzas/Datos Financieros
archivoExcel = os.path.abspath(os.path.join(directorio_actual, "..", "..", "..", "Datos Financieros", "TransactionExcelFile.xlsx"))

if not os.path.exists(archivoExcel):
    sys.stderr.write(f"No se encontró el archivo Excel en la ruta:\n{archivoExcel}\n")
    sys.exit(1)

# 3. Lectura del archivo Excel
try:
    df = pd.read_excel(archivoExcel, skiprows=7)
    print(f"Excel leído correctamente desde: {archivoExcel}")
except Exception as e:
    sys.stderr.write(f"Error al abrir el archivo Excel ({archivoExcel}): {e}\n")
    sys.exit(1)

# Renombrado de columnas
df.columns = ['Fecha_Operacion', 'Fecha_Valor', 'Concepto', 'Importe', 'Saldo', 'Divisa']

def limpiar_dinero_excel(columna):
    if pd.api.types.is_numeric_dtype(columna):
        return columna
    contenido = columna.astype(str).str.strip()
    contenido = contenido.str.replace(r'[^\d,.-]', '', regex=True)
    contenido = contenido.str.replace('.', '', regex=False)
    contenido = contenido.str.replace(',', '.', regex=False)
    return pd.to_numeric(contenido, errors='coerce')

df['Importe'] = limpiar_dinero_excel(df['Importe'])
df['Saldo'] = limpiar_dinero_excel(df['Saldo'])
df['Fecha_Operacion'] = pd.to_datetime(df['Fecha_Operacion'], dayfirst=True, errors='coerce')
df['Fecha_Valor'] = pd.to_datetime(df['Fecha_Valor'], dayfirst=True, errors='coerce')
df['Concepto'] = df['Concepto'].astype(str).str.strip()
df['Concepto'] = df['Concepto'].str.replace(r'TRANSACCION\s+CONTACTLESS\s+EN', '', regex=True, case=False).str.strip()
df['Concepto'] = df['Concepto'].str.replace(r'COMPRA', '', regex=True, case=False).str.strip()

REGLAS_CATEGORIAS = {
    'Nomina': ['NOMINA', 'ORDENANTE', 'HABERES', 'SALARIO'],
    'Efectivo': ['CAJERO', 'RETIRADA', 'EFECTIVO', 'INGRESO EN EFECTIVO', 'DISPENSACION'],
    'Compras y Moda': ['PRIMARK', 'ZARA', 'H&M', 'MANGO', 'DECATHLON', 'IKEA', 'LEFTHANDES', 'CORTE INGLES', 'SHEIN', 'TEMU', 'AMAZON'],
    'Supermercado': ['ALIMERKA', 'MERCADONA', 'CARREFOUR', 'DIA', 'ALCAMPO', 'LIDL', 'EROSKI', 'CONSUM', 'MASYMAS', 'FRUTERIA', 'PANADERIA'],
    'Restauracion': ['CAFE', 'BAR', 'RESTAURANTE', 'BURGER KING', 'MCDONALD', 'TELEPIZZA', 'DOMINOS', 'STARBUCKS', 'TABERNA', 'PUB', 'FOOD PLANET'],
    'Entretenimiento': ['STEAM', 'NETFLIX', 'SPOTIFY', 'NINTENDO', 'PLAYSTATION', 'PLAY STATION', 'XBOX', 'CINE', 'YOUTUBEPREMIUM'],
    'Salud': ['FARMACIA', 'DENTISTA', 'CLINICA', 'MEDICO', 'OPTICA', 'SANIEDAD', 'HOSPITAL'],
    'Transporte': ['GASOLINERA', 'REPSOL', 'CEPSA', 'BP', 'ALSA', 'RENFE', 'UBER', 'CABIFY', 'BOLT', 'PEAJE', 'PARKING', 'ESTACIONAMIENTO'],
    'Suscripciones': ['AMAZON PRIME', 'ICLOUD', 'MICROSOFT', 'ADOBE', 'GOOGLE STORAGE', 'CHATGPT', 'OPENAI'],
    'Hogar y Facturas': ['TELEFONICA', 'MOVISTAR', 'VODAFONE', 'ORANGE', 'DIGI', 'IBERDROLA', 'ENDESA', 'ALSA AGUA', 'COMUNIDAD', 'ALQUILER']
}

def asignar_categoria(concepto):
    concepto_upper = str(concepto).upper()
    for categoria, palabras_clave in REGLAS_CATEGORIAS.items():
        for palabra in palabras_clave:
            if palabra in concepto_upper:
                return categoria
    return 'Otros'

df['Categoria'] = df['Concepto'].apply(asignar_categoria)

conn_str = (
    "DRIVER={ODBC Driver 17 for SQL Server};"
    "SERVER=.\\SQLEXPRESS;" 
    "DATABASE=FinanzasDB;"
    "Trusted_Connection=yes;"
)

try:
    conn = pyodbc.connect(conn_str)
    cursor = conn.cursor()
    
    cursor.execute("TRUNCATE TABLE Transacciones")
    
    for index, fila in df.iterrows():
        cursor.execute("""
            INSERT INTO Transacciones (
                Fecha_Operacion, Fecha_Valor, Concepto, Categoria, Importe, Saldo, Divisa
            ) VALUES (?, ?, ?, ?, ?, ?, ?)
        """, 
        fila['Fecha_Operacion'].to_pydatetime() if pd.notnull(fila['Fecha_Operacion']) else None,
        fila['Fecha_Valor'].to_pydatetime() if pd.notnull(fila['Fecha_Valor']) else None,
        fila['Concepto'],
        fila['Categoria'],
        float(fila['Importe']) if pd.notnull(fila['Importe']) else 0.0,
        float(fila['Saldo']) if pd.notnull(fila['Saldo']) else 0.0,
        fila['Divisa']
        )
    
    conn.commit()
    cursor.close()
    conn.close()

except Exception as e:
    sys.stderr.write(f"Error durante el guardado en SQL Server: {e}\n")
    sys.exit(1)