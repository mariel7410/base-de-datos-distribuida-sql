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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (string.IsNullOrWhiteSpace(IDtextBox1.Text) ||
                string.IsNullOrWhiteSpace(RetirartextBox2.Text) ||
                CiudadcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener valores de los controles
                string id = IDtextBox1.Text;
                decimal retirar = Convert.ToDecimal(RetirartextBox2.Text);
                string ciudad = CiudadcomboBox.SelectedItem.ToString();

                // Crear la conexión
                Conexion conexion = new Conexion();
                using (OracleConnection con = conexion.CrearConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("RetirarDinero", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Definir los parámetros del procedimiento almacenado
                        cmd.Parameters.Add("Contraseña(ID)", OracleDbType.Varchar2).Value = id;
                        cmd.Parameters.Add("retirar", OracleDbType.Decimal).Value = retirar;
                        cmd.Parameters.Add("Ciudad", OracleDbType.Varchar2).Value = ciudad;

                        // Ejecutar el procedimiento
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Retiro de ${retirar} realizado exitosamente con id {id}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
