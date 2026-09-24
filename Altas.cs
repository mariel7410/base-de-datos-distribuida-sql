using System;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD_Banco;

namespace Int_Empleado
{
    public partial class Altas : Form
    {
        public Altas()
        {
            InitializeComponent();
        }

        



        private void CancelarBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void GuardarBtn_Click_1(object sender, EventArgs e)
        {
            // Validar entradas
            if (string.IsNullOrWhiteSpace(ComboTipo.Text) ||
                string.IsNullOrWhiteSpace(TxtSaldo.Text) ||
                string.IsNullOrWhiteSpace(TxtTarjeta.Text) ||
                ComboCiudad.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TxtIDCliente.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener valores de los controles
                string tipoCuenta = ComboTipo.SelectedItem.ToString();
                decimal saldo = Convert.ToDecimal(TxtSaldo.Text);
                string nTarjeta = TxtTarjeta.Text;
                string ciudad = ComboCiudad.SelectedItem.ToString();
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

                    using (OracleCommand cmd = new OracleCommand("DarDeAltaCuenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Definir los parámetros del procedimiento almacenado
                        cmd.Parameters.Add("p_Tipo", OracleDbType.Varchar2).Value = tipoCuenta;
                        cmd.Parameters.Add("p_Saldo", OracleDbType.Decimal).Value = saldo;
                        cmd.Parameters.Add("p_NTarjeta", OracleDbType.Varchar2).Value = nTarjeta;
                        cmd.Parameters.Add("p_Ciudad", OracleDbType.Varchar2).Value = ciudad;
                        cmd.Parameters.Add("p_IdCliente", OracleDbType.Int32).Value = idCliente;

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Cuenta creada exitosamente para el cliente con ID {idCliente}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Actualizar DataGridView con los datos de las cuentas (si es necesario)
                datosSql datos = new datosSql();
                string consultaCuentas = "SELECT saldo, ntarjeta FROM Cuenta";


            }
            catch (Exception ex)
            {
                // Manejar excepciones de forma adecuada
                MessageBox.Show($"Error al dar de alta la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click_1(object sender, EventArgs e)
        {
            EmpleadoForm mainForm = new EmpleadoForm();
            mainForm.Show();
            this.Close();
        }
    }
 }
