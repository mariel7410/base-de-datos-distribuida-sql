using BD_Banco;
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

namespace Int_Empleado
{
    public partial class Bajas : Form
    {
        public Bajas()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void EliminarBtn_Click_1(object sender, EventArgs e)
        {
            // Validar que el ID de cuenta haya sido ingresado
            if (string.IsNullOrWhiteSpace(TxtIDC.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID de la cuenta que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener los valores de los campos
                int idCuenta = Convert.ToInt32(TxtIDC.Text);
                string tipoCuenta = ComboTipo.SelectedItem.ToString();
                string numeroTarjeta = TxtNum.Text;
                int idCliente = Convert.ToInt32(TxtIDCliente.Text);

                // Crear la conexión
                Conexion conexion = new Conexion();
                using (OracleConnection con = conexion.CrearConexion())
                {
                    // Asegurarse de que la conexión esté abierta
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    // Llamar al procedimiento almacenado DarDeBajaCuenta
                    using (OracleCommand cmd = new OracleCommand("DarDeBajaCuenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("vid", OracleDbType.Int32).Value = idCuenta;

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        // Mensaje de éxito
                        MessageBox.Show($"Cuenta con ID {idCuenta} eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Limpiar los campos después de eliminar la cuenta
                TxtIDC.Clear();
                ComboTipo.SelectedIndex = -1;
                TxtNum.Clear();
                TxtIDCliente.Clear();


            }
            catch (OracleException ex)
            {
                // Manejar errores específicos de Oracle
                if (ex.Number == -2292)  // Código de error para restricción de eliminación por registros relacionados
                {
                    MessageBox.Show($"No se puede eliminar la cuenta con ID {TxtIDC.Text} debido a registros relacionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al eliminar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores generales
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click_1(object sender, EventArgs e)
        {
            EmpleadoForm mainForm = new EmpleadoForm();
            mainForm.Show();
            this.Close();
        }
    }
}
