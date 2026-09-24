using System.Drawing;
using System.Windows.Forms;

namespace Int_Empleado
{
    partial class EmpleadoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            AltaBtn = new Button();
            BajaBtn = new Button();
            CambiosBtn = new Button();
            ConsultaBtn = new Button();
            SalirBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(238, 53);
            label1.Name = "label1";
            label1.Size = new Size(292, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la interfaz para empleados.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(302, 94);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 1;
            label2.Text = "Seleccione una opción:";
            // 
            // AltaBtn
            // 
            AltaBtn.BackColor = Color.AliceBlue;
            AltaBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            AltaBtn.Location = new Point(129, 159);
            AltaBtn.Name = "AltaBtn";
            AltaBtn.Size = new Size(168, 41);
            AltaBtn.TabIndex = 2;
            AltaBtn.Text = "Alta de Cuentas";
            AltaBtn.UseVisualStyleBackColor = false;
            AltaBtn.Click += AltaBtn_Click;
            // 
            // BajaBtn
            // 
            BajaBtn.BackColor = Color.AliceBlue;
            BajaBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            BajaBtn.Location = new Point(479, 159);
            BajaBtn.Name = "BajaBtn";
            BajaBtn.Size = new Size(168, 41);
            BajaBtn.TabIndex = 3;
            BajaBtn.Text = "Baja de Cuentas";
            BajaBtn.UseVisualStyleBackColor = false;
            BajaBtn.Click += BajaBtn_Click;
            // 
            // CambiosBtn
            // 
            CambiosBtn.BackColor = Color.AliceBlue;
            CambiosBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            CambiosBtn.Location = new Point(129, 232);
            CambiosBtn.Name = "CambiosBtn";
            CambiosBtn.Size = new Size(168, 41);
            CambiosBtn.TabIndex = 4;
            CambiosBtn.Text = "Cambios";
            CambiosBtn.UseVisualStyleBackColor = false;
            CambiosBtn.Click += CambiosBtn_Click;
            // 
            // ConsultaBtn
            // 
            ConsultaBtn.BackColor = Color.AliceBlue;
            ConsultaBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ConsultaBtn.Location = new Point(479, 232);
            ConsultaBtn.Name = "ConsultaBtn";
            ConsultaBtn.Size = new Size(168, 41);
            ConsultaBtn.TabIndex = 5;
            ConsultaBtn.Text = "Consultas";
            ConsultaBtn.UseVisualStyleBackColor = false;
            ConsultaBtn.Click += ConsultaBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.BackColor = Color.AliceBlue;
            SalirBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            SalirBtn.Location = new Point(302, 318);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(168, 41);
            SalirBtn.TabIndex = 6;
            SalirBtn.Text = "Salir";
            SalirBtn.UseVisualStyleBackColor = false;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(SalirBtn);
            Controls.Add(ConsultaBtn);
            Controls.Add(CambiosBtn);
            Controls.Add(BajaBtn);
            Controls.Add(AltaBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button AltaBtn;
        private Button BajaBtn;
        private Button CambiosBtn;
        private Button ConsultaBtn;
        private Button SalirBtn;
    }
}
