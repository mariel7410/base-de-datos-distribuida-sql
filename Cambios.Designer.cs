using System.Drawing;
using System.Windows.Forms;

namespace Int_Empleado
{
    partial class Cambios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIDCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.ComboCiudad = new System.Windows.Forms.ComboBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.DatosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(210, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionó la opción para Cambios en Cuentas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(63, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de la cuenta:";
            // 
            // TxtIDCuenta
            // 
            this.TxtIDCuenta.Location = new System.Drawing.Point(189, 68);
            this.TxtIDCuenta.Name = "TxtIDCuenta";
            this.TxtIDCuenta.Size = new System.Drawing.Size(229, 20);
            this.TxtIDCuenta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nuevo saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(63, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nueva ciudad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(63, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nuevo tipo de cuenta:";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(169, 99);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(218, 20);
            this.TxtSaldo.TabIndex = 6;
            // 
            // ComboCiudad
            // 
            this.ComboCiudad.FormattingEnabled = true;
            this.ComboCiudad.Items.AddRange(new object[] {
            "Puebla",
            "Ciudad de México"});
            this.ComboCiudad.Location = new System.Drawing.Point(177, 129);
            this.ComboCiudad.Name = "ComboCiudad";
            this.ComboCiudad.Size = new System.Drawing.Size(104, 21);
            this.ComboCiudad.TabIndex = 7;
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Ahorros",
            "Cheques"});
            this.ComboTipo.Location = new System.Drawing.Point(232, 194);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(104, 21);
            this.ComboTipo.TabIndex = 8;
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.ModificarBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ModificarBtn.Location = new System.Drawing.Point(472, 81);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(135, 30);
            this.ModificarBtn.TabIndex = 9;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = false;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click_1);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.BorrarBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BorrarBtn.Location = new System.Drawing.Point(472, 125);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(135, 30);
            this.BorrarBtn.TabIndex = 10;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = false;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click_1);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelarBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.CancelarBtn.Location = new System.Drawing.Point(472, 169);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(135, 30);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click_1);
            // 
            // DatosdataGridView1
            // 
            this.DatosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView1.Location = new System.Drawing.Point(56, 239);
            this.DatosdataGridView1.Name = "DatosdataGridView1";
            this.DatosdataGridView1.Size = new System.Drawing.Size(553, 130);
            this.DatosdataGridView1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(62, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Número de tarjeta:";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(214, 163);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(216, 20);
            this.TxtNum.TabIndex = 14;
            // 
            // Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DatosdataGridView1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.ComboCiudad);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIDCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cambios";
            this.Text = "Cambios";
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtIDCuenta;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtSaldo;
        private ComboBox ComboCiudad;
        private ComboBox ComboTipo;
        private Button ModificarBtn;
        private Button BorrarBtn;
        private Button CancelarBtn;
        private DataGridView DatosdataGridView1;
        private Label label6;
        private TextBox TxtNum;
    }
}