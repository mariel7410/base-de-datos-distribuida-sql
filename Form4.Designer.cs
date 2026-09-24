namespace BD_Banco
{
    partial class Form4
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
            this.Regresar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblFilas_label5 = new System.Windows.Forms.Label();
            this.CiudadcomboBox = new System.Windows.Forms.ComboBox();
            this.RetirartextBox2 = new System.Windows.Forms.TextBox();
            this.IDtextBox1 = new System.Windows.Forms.TextBox();
            this.DatosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(665, 190);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(102, 39);
            this.Regresar.TabIndex = 21;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(665, 142);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(102, 39);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblFilas_label5
            // 
            this.lblFilas_label5.AutoSize = true;
            this.lblFilas_label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblFilas_label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilas_label5.Location = new System.Drawing.Point(393, 343);
            this.lblFilas_label5.Name = "lblFilas_label5";
            this.lblFilas_label5.Size = new System.Drawing.Size(211, 27);
            this.lblFilas_label5.TabIndex = 19;
            this.lblFilas_label5.Text = "NÚMERO DE FILAS:";
            // 
            // CiudadcomboBox
            // 
            this.CiudadcomboBox.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadcomboBox.FormattingEnabled = true;
            this.CiudadcomboBox.Items.AddRange(new object[] {
            "Puebla",
            "CDMX"});
            this.CiudadcomboBox.Location = new System.Drawing.Point(369, 228);
            this.CiudadcomboBox.Name = "CiudadcomboBox";
            this.CiudadcomboBox.Size = new System.Drawing.Size(251, 28);
            this.CiudadcomboBox.TabIndex = 18;
            this.CiudadcomboBox.Text = "Selecciona Sucursal";
            // 
            // RetirartextBox2
            // 
            this.RetirartextBox2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetirartextBox2.Location = new System.Drawing.Point(369, 180);
            this.RetirartextBox2.Name = "RetirartextBox2";
            this.RetirartextBox2.Size = new System.Drawing.Size(251, 27);
            this.RetirartextBox2.TabIndex = 17;
            // 
            // IDtextBox1
            // 
            this.IDtextBox1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtextBox1.Location = new System.Drawing.Point(369, 135);
            this.IDtextBox1.Name = "IDtextBox1";
            this.IDtextBox1.Size = new System.Drawing.Size(251, 27);
            this.IDtextBox1.TabIndex = 16;
            // 
            // DatosdataGridView1
            // 
            this.DatosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView1.Location = new System.Drawing.Point(32, 288);
            this.DatosdataGridView1.Name = "DatosdataGridView1";
            this.DatosdataGridView1.RowHeadersWidth = 51;
            this.DatosdataGridView1.RowTemplate.Height = 24;
            this.DatosdataGridView1.Size = new System.Drawing.Size(341, 150);
            this.DatosdataGridView1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dinero a retirar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sucursal a la que pertenece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(245, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 85);
            this.label2.TabIndex = 12;
            this.label2.Text = "Retirar Dinero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña (ID)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 22;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblFilas_label5);
            this.Controls.Add(this.CiudadcomboBox);
            this.Controls.Add(this.RetirartextBox2);
            this.Controls.Add(this.IDtextBox1);
            this.Controls.Add(this.DatosdataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblFilas_label5;
        private System.Windows.Forms.ComboBox CiudadcomboBox;
        private System.Windows.Forms.TextBox RetirartextBox2;
        private System.Windows.Forms.TextBox IDtextBox1;
        private System.Windows.Forms.DataGridView DatosdataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}