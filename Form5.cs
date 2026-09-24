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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (string.IsNullOrWhiteSpace(OrigentextBox1.Text) ||
                string.IsNullOrWhiteSpace(DestinotextBox2.Text) ||
                string.IsNullOrWhiteSpace(MontotextBox1.Text) ||
                CiudadcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener valores de los controles
                string origen = OrigentextBox1.Text;
                string destino = DestinotextBox2.Text;
                decimal monto = Convert.ToDecimal(MontotextBox1.Text);
                string ciudad = CiudadcomboBox.SelectedItem.ToString();

                // Crear la conexión
                Conexion conexion = new Conexion();
                using (OracleConnection con = conexion.CrearConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("TransferirDinero", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Definir los parámetros del procedimiento almacenado
                        cmd.Parameters.Add("Cuenta Origen", OracleDbType.Varchar2).Value = origen;
                        cmd.Parameters.Add("Cuenta Destino", OracleDbType.Varchar2).Value = destino;
                        cmd.Parameters.Add("monto", OracleDbType.Decimal).Value = monto;
                        cmd.Parameters.Add("Ciudad", OracleDbType.Varchar2).Value = ciudad;

                        // Ejecutar el procedimiento
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Tranferencia de ${monto} realizada exitosamente | Cuenta Origen {origen} | Cuenta Destino {destino}", "Tranferencia Realizada Con Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Actualizar DataGridView con los datos de las cuentas
                datosSql datos = new datosSql();

                // Consulta específica para obtener datos de la tabla Cuenta
                string consultaCuentas = "SELECT id, ntarjeta, saldo FROM Cuenta";

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

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
