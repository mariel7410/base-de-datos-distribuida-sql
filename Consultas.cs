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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ConsultarBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumero.Text))
            {
                MessageBox.Show("Por favor, introduzca el número de tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string numeroTarjeta = TxtNumero.Text;

                // Conexión a la base de datos
                Conexion conexion = new Conexion();
                using (OracleConnection con = conexion.CrearConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("ReporteMovimientosMes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        cmd.Parameters.Add("p_NTarjeta", OracleDbType.Varchar2).Value = numeroTarjeta;

                        // Parámetro de salida (ref cursor)
                        cmd.Parameters.Add("MovimientosMesCursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Mostrar los resultados en el DataGridView
                            DatosdataGridView.DataSource = dt;
                        }
                    }
                }

                MessageBox.Show("Consulta realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar movimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarBtn_Click_1(object sender, EventArgs e)
        {
            TxtNumero.Clear();
        }

        private void CancelarBtn_Click_1(object sender, EventArgs e)
        {
            EmpleadoForm mainForm = new EmpleadoForm();
            mainForm.Show();
            this.Close();
        }
    }
}
