using Int_Empleado;
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
    public partial class IniciarSesion : Form
    {
        private Conexion conexion;
        private string tipoUsuario;
        public IniciarSesion(string tipoUsuario)
        {
            InitializeComponent();
            conexion = new Conexion();
            this.tipoUsuario = tipoUsuario;

            if (tipoUsuario == "Cliente")
            {
                IngresarPrimeraVezLinkLabel.Visible = true;
            }
            else
            {
                IngresarPrimeraVezLinkLabel.Visible = false;
            }

            ContraseñaTextBox.PasswordChar = '*';
        }

        private void IngresarPrimeraVezLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Si el la primera vez que ingresas, escribe tu nombre completo y usa tu RFC como contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            string nombreCompleto = UsuarioTextBox.Text.Trim();
            string contrasena = ContraseñaTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nombreCompleto) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Separacion del nombre completo en partes (nombre y apellidos)
            string[] partesNombre = nombreCompleto.Split(' ');

            if (partesNombre.Length < 2)
            {
                MessageBox.Show("Por favor, ingrese su nombre completo con al menos un apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tomar la primera parte como el nombre y el resto como apellidos
            string nombre = partesNombre[0];
            string apellido = string.Join(" ", partesNombre.Skip(1));

            try
            {
                // Verificar si es empleado o cliente según el tipo de usuario
                if (tipoUsuario == "Empleado")
                {
                    // Verificar si es empleado
                    bool existeEmpleado = VerificarEmpleado(nombre, apellido, contrasena);

                    if (existeEmpleado)
                    {
                        MessageBox.Show("Bienvenido(a) empleado(a).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        EmpleadoForm frm = new EmpleadoForm();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (tipoUsuario == "Cliente")
                {
                    // Verificar si es cliente
                    bool existeCliente = VerificarCliente(nombre, apellido, contrasena);

                    if (existeCliente)
                    {
                        MessageBox.Show("Bienvenido(a) cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        ClienteForm frm = new ClienteForm();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarEmpleado(string nombre, string apellido, string rfc)
        {
            using (var conn = conexion.CrearConexion())
            {
                string query = "SELECT COUNT(*) FROM EMPLEADOS WHERE nombre = :nombre AND apellido = :apellido AND rfc = :rfc";
                using (var cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("nombre", nombre));
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("apellido", apellido));
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("rfc", rfc));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool VerificarCliente(string nombre, string apellido, string rfc)
        {
            using (var conn = conexion.CrearConexion())
            {
                string query = "SELECT COUNT(*) FROM CLIENTES WHERE nombre = :nombre AND apellido = :apellido AND rfc = :rfc";
                using (var cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("nombre", nombre));
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("apellido", apellido));
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("rfc", rfc));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        private void AtrasButton_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void MostrarContraseñaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                
                ContraseñaTextBox.PasswordChar = '\0'; 
                MostrarContraseñaCheckBox.Text = "🙈";
            }
            else
            {
                
                ContraseñaTextBox.PasswordChar = '*';
                MostrarContraseñaCheckBox.Text = "👁";
            }
        }
    }
}
