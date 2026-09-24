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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (string.IsNullOrWhiteSpace(NumeroCuentatextBox1.Text) ||
                string.IsNullOrWhiteSpace(CantidadEnviartextBox2.Text) ||
                CiudadcomboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener valores de los controles
                string numeroCuenta = NumeroCuentatextBox1.Text;
                decimal monto = Convert.ToDecimal(CantidadEnviartextBox2.Text);
                string ciudad = CiudadcomboBox1.SelectedItem.ToString();

                // Crear la conexión
                Conexion conexion = new Conexion();
                using (OracleConnection con = conexion.CrearConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("DepositarDinero", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Definir los parámetros del procedimiento almacenado
                        cmd.Parameters.Add("CuentaDestino", OracleDbType.Varchar2).Value = numeroCuenta;
                        cmd.Parameters.Add("monto", OracleDbType.Decimal).Value = monto;
                        cmd.Parameters.Add("Ciudad", OracleDbType.Varchar2).Value = ciudad;

                        // Ejecutar el procedimiento
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Depósito de ${monto} realizado exitosamente a la cuenta {numeroCuenta}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Actualizar DataGridView con los datos de las cuentas
                datosSql datos = new datosSql();

                // Consulta específica para obtener datos de la tabla Cuenta
                string consultaCuentas = "SELECT saldo, ntarjeta FROM Cuenta";

                // Llamar a Listar con la consulta y actualizar el DataGridView
                DatosdataGridView1.DataSource = datos.Listar(consultaCuentas);

                // Mostrar el número de filas (restando una fila por el encabezado)
                lblFilas_label5.Text = $"NÚMERO DE FILAS: {DatosdataGridView1.Rows.Count - 1}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el depósito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


