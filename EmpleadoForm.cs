using System;
using System.Windows.Forms;

namespace Int_Empleado
{
    public partial class EmpleadoForm : Form
    {
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        private void AltaBtn_Click(object sender, EventArgs e)
        {
            Altas altasForm = new Altas();
            altasForm.Show();
            this.Hide();
        }

        private void BajaBtn_Click(object sender, EventArgs e)
        {
            Bajas bajasForm = new Bajas();
            bajasForm.Show();
            this.Hide();
        }

        private void CambiosBtn_Click(object sender, EventArgs e)
        {
            Cambios cambiosForm = new Cambios();
            cambiosForm.Show();
            this.Hide();
        }

        private void ConsultaBtn_Click(object sender, EventArgs e)
        {
            Consultas consultasForm = new Consultas();
            consultasForm.Show();
            this.Hide();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
