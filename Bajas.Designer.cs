using System.Drawing;
using System.Windows.Forms;

namespace Int_Empleado
{
    partial class Bajas
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
            this.TxtIDC = new System.Windows.Forms.TextBox();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIDCliente = new System.Windows.Forms.TextBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(225, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionó la opción para Baja de Cuentas.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduzca el ID de la cuenta:";
            // 
            // TxtIDC
            // 
            this.TxtIDC.Location = new System.Drawing.Point(335, 92);
            this.TxtIDC.Name = "TxtIDC";
            this.TxtIDC.Size = new System.Drawing.Size(189, 20);
            this.TxtIDC.TabIndex = 2;
            // 
            // TipoLabel
            // 
            this.TipoLabel.AutoSize = true;
            this.TipoLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TipoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TipoLabel.Location = new System.Drawing.Point(117, 123);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(118, 20);
            this.TipoLabel.TabIndex = 3;
            this.TipoLabel.Text = "Tipo de Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(117, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de Tarjeta:";
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Ahorros",
            "Cheques"});
            this.ComboTipo.Location = new System.Drawing.Point(241, 122);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(104, 21);
            this.ComboTipo.TabIndex = 5;
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(267, 154);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(231, 20);
            this.TxtNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(117, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID de Cliente:";
            // 
            // TxtIDCliente
            // 
            this.TxtIDCliente.Location = new System.Drawing.Point(230, 185);
            this.TxtIDCliente.Name = "TxtIDCliente";
            this.TxtIDCliente.Size = new System.Drawing.Size(115, 20);
            this.TxtIDCliente.TabIndex = 8;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.EliminarBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.EliminarBtn.Location = new System.Drawing.Point(64, 277);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(144, 42);
            this.EliminarBtn.TabIndex = 9;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click_1);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.BorrarBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BorrarBtn.Location = new System.Drawing.Point(267, 277);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(144, 42);
            this.BorrarBtn.TabIndex = 10;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = false;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelarBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.CancelarBtn.Location = new System.Drawing.Point(473, 277);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(144, 42);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click_1);
            // 
            // Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.TxtIDCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoLabel);
            this.Controls.Add(this.TxtIDC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bajas";
            this.Text = "Bajas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtIDC;
        private Label TipoLabel;
        private Label label3;
        private ComboBox ComboTipo;
        private TextBox TxtNum;
        private Label label4;
        private TextBox TxtIDCliente;
        private Button EliminarBtn;
        private Button BorrarBtn;
        private Button CancelarBtn;
    }
}