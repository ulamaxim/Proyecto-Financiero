using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Financiero
{
    public partial class Ventana_Inicial : Form
    {
        public Ventana_Inicial()
        {
            InitializeComponent();
        }

        private void Ventana_Inicial_Load(object sender, EventArgs e)
        {
            // 1. Ejecutamos el script de Python para actualizar la base de datos
            EjecutarScriptPython();

            // 2. Cargamos los datos actualizados en tu DataGridView
            CargarTransacciones();
        }

        //===================================================
        //         EJECUCION DE SCRIPT DE PYTHON
        //===================================================
        private void EjecutarScriptPython()
        {
            // === OBTENER LA RUTA DEL USUARIO ===
            string carpetaUsuario = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // === CONSTRUIR LAS RUTAS EXACTAS ===
            // Ruta al ejecutable de Python (en tu AppData)
            string pythonPath = Path.Combine(carpetaUsuario, @"AppData\Local\Programs\Python\Python39\python.exe");

            // Ruta al script de Python (dentro de tu carpeta del proyecto)
            string scriptPath = Path.Combine(carpetaUsuario, @"source\repos\Proyecto Financiero\Backend Finanzas\BackendFinanzas.py");

            // === COMPROBACIONES DE SEGURIDAD ===
            if (!File.Exists(pythonPath))
            {
                throw new FileNotFoundException($"No se pudo encontrar el ejecutable de Python en la ruta:\n{pythonPath}\n\nPor favor, verifica si la versión de Python instalada es la 3.9 o si la ruta ha cambiado.");
            }

            if (!File.Exists(scriptPath))
            {
                throw new FileNotFoundException($"No se pudo encontrar tu script de Python en la ruta:\n{scriptPath}\n\nVerifica que el nombre del archivo '.py' coincida exactamente.");
            }

            // === EJECUCIÓN SILENCIOSA DEL PROCESO ===
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonPath;
            // Envolvemos el script entre comillas por si hay espacios en "Proyecto Financiero" o "Backend Finanzas"
            start.Arguments = $"\"{scriptPath}\"";
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process proceso = Process.Start(start))
            {
                // Esperamos a que Python termine de limpiar e insertar datos en SQL Server
                proceso.WaitForExit();

                // Comprobamos si hubo algún error dentro de la ejecución de Python
                using (StreamReader reader = proceso.StandardError)
                {
                    string erroresPython = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(erroresPython))
                    {
                        // Mostramos el error real de Python si algo falló internamente (ej. error de pandas, conexión SQL, etc.)
                        MessageBox.Show($"Python ejecutó con errores:\n\n{erroresPython}", "Error en Script de Python", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //===================================================
        //         CARGA DE DATOS A DATAGRIDVIEW
        //===================================================

        DataClasses1DataContext datalinq = new DataClasses1DataContext();
        public void CargarTransacciones()
        {
            var transactions = from vw in datalinq.vw_datagrid1
                               select vw;
            dataGridView1.DataSource = transactions;
            FormatearDiseñoTabla();
            SaldoIngresosGastos(transactions);
        }

        //================================================
        //          FORMATEO DE TABLAS 
        //================================================
        private void FormatearDiseñoTabla()
        {
            // Ajustamos las columnas para que llenen el espacio del dataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumnHeadersHeight();

            // Formateamos Fecha_Operacion
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridView1.Columns["Fecha_Operacion"].FillWeight = 80;
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formateamos Concepto
            dataGridView1.Columns["Concepto"].FillWeight = 280;

            // Formateamos Categoria
            dataGridView1.Columns["Categoria"].FillWeight = 70;

            // Formateamos Importe
            dataGridView1.Columns["Importe"].FillWeight = 45;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formateamos Saldo
            dataGridView1.Columns["Saldo"].FillWeight = 45;
            dataGridView1.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Hacemos que las filas alternen de color para facilitar la lectura
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250);

        }

        //======================================================
        //         CALCULO DE SALDO INGRESOS Y GASTOS
        //======================================================
        void SaldoIngresosGastos(IEnumerable<vw_datagrid1> transactions)
        {
            CultureInfo euro = new CultureInfo("es-ES");
            // Saldo Actual
            lblSaldoValor.Text = (transactions.FirstOrDefault()?.Saldo ?? 0).ToString("C2", euro);

            // Creamos una la fecha limite con la que vamos a comparar para sacar los datos solo del ultimo mes
            DateTime ultimaFecha = transactions
                .Where(i => i.Fecha_Operacion.HasValue)
                .Max(i => i.Fecha_Operacion.Value);

            int mesLim = ultimaFecha.Month;
            int añoLim = ultimaFecha.Year;

            // Ingresos. Ccalculamos la suma de valores positivos de la columna importe
            // del ultimo mes natural
            decimal ingresos = transactions
                .Where(i => i.Fecha_Operacion.Value.Month == mesLim &&
                            i.Fecha_Operacion.Value.Year == añoLim)
                .Where(i => i.Importe.HasValue && i.Importe > 0)
                .Sum(i => i.Importe.Value);


            // Gastos. Hacemos calculo de valores negativos de la columna Importe
            // del ultimo mes natural
            decimal gastos = transactions
                .Where(i => i.Fecha_Operacion.Value.Month == mesLim &&
                            i.Fecha_Operacion.Value.Year == añoLim)
                .Where(g => g.Importe.HasValue && g.Importe < 0)
                .Sum(g => g.Importe.Value);

            // Pasamos los valores a los labels
            lblIngresosValor.Text = ingresos.ToString("C2", euro);
            lblGastosValor.Text = gastos.ToString("C2", euro);
        }
    }
}