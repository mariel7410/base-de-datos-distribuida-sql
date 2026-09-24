using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Banco
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Validar entrada del número de tarjeta
            if (string.IsNullOrWhiteSpace(numTarjetatextBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de tarjeta válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener número de tarjeta desde el TextBox
                string numeroTarjeta = numTarjetatextBox1.Text;

                // Llamar al método que ejecuta el procedimiento almacenado
                string informacion = ObtenerInformacionCliente(numeroTarjeta);

                // Mostrar el resultado en la interfaz
                if (!string.IsNullOrEmpty(informacion))
                {
                    MostrartextBox2.Text = informacion; // Caja de texto donde se muestra la información
                }
                else
                {
                    MostrartextBox2.Text = "No se encontró información para el número de tarjeta proporcionado.";
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Ocurrió un error al obtener la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ObtenerInformacionCliente(string numeroTarjeta)
        {
            string informacion = string.Empty;

            try
            {
                // Crear conexión a la base de datos
                Conexion conexion = new Conexion();
                using (OracleConnection con = conexion.CrearConexion())
                {
                    // Configurar el comando para llamar al procedimiento almacenado
                    using (OracleCommand cmd = new OracleCommand("VerEstadoCuenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Configurar parámetros de entrada y salida
                        cmd.Parameters.Add("vnumerotarjeta", OracleDbType.Varchar2).Value = numeroTarjeta;
                        cmd.Parameters.Add("informacion", OracleDbType.Varchar2, 4000).Direction = ParameterDirection.Output;

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        // Obtener el valor del parámetro de salida
                        informacion = cmd.Parameters["informacion"].Value.ToString();
                    }
                }

                // Dar formato a la información para mostrarla de manera más bonita
                if (!string.IsNullOrEmpty(informacion))
                {
                    // Divide la información en diferentes líneas para mayor claridad
                    informacion = FormatearInformacion(informacion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message, ex);
            }

            return informacion;
        }
        private string FormatearInformacion(string informacion)
        {
            // Suponiendo que la información sigue un formato específico con separadores (por ejemplo, "|")
            string[] partes = informacion.Split('|');
            StringBuilder resultado = new StringBuilder();

            foreach (string parte in partes)
            {
                // Eliminar espacios innecesarios y agregar saltos de línea
                resultado.AppendLine(parte.Trim());
            }

            return resultado.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }

}
