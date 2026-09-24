using System;
using System.Data;
using System.Windows.Forms;

namespace BD_Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void EmpleadoButton_Click(object sender, EventArgs e)
        {
            IniciarSesion IniciarSesionForm = new IniciarSesion("Empleado");
            IniciarSesionForm.Show();
            this.Hide();
        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            IniciarSesion IniciarSesionForm = new IniciarSesion("Cliente");
            IniciarSesionForm.Show();
            this.Hide();
        }
    }
}
