namespace BD_Banco
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroCuentatextBox1 = new System.Windows.Forms.TextBox();
            this.CantidadEnviartextBox2 = new System.Windows.Forms.TextBox();
            this.CiudadcomboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFilas_label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Cuenta Depositar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(221, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 85);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depositar Dinero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sucursal a la que pertenece";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad a enviar";
            // 
            // DatosdataGridView1
            // 
            this.DatosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView1.Location = new System.Drawing.Point(-1, 300);
            this.DatosdataGridView1.Name = "DatosdataGridView1";
            this.DatosdataGridView1.RowHeadersWidth = 51;
            this.DatosdataGridView1.RowTemplate.Height = 24;
            this.DatosdataGridView1.Size = new System.Drawing.Size(341, 150);
            this.DatosdataGridView1.TabIndex = 4;
            // 
            // NumeroCuentatextBox1
            // 
            this.NumeroCuentatextBox1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroCuentatextBox1.Location = new System.Drawing.Point(334, 119);
            this.NumeroCuentatextBox1.Name = "NumeroCuentatextBox1";
            this.NumeroCuentatextBox1.Size = new System.Drawing.Size(251, 27);
            this.NumeroCuentatextBox1.TabIndex = 5;
            // 
            // CantidadEnviartextBox2
            // 
            this.CantidadEnviartextBox2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEnviartextBox2.Location = new System.Drawing.Point(334, 180);
            this.CantidadEnviartextBox2.Name = "CantidadEnviartextBox2";
            this.CantidadEnviartextBox2.Size = new System.Drawing.Size(251, 27);
            this.CantidadEnviartextBox2.TabIndex = 6;
            // 
            // CiudadcomboBox1
            // 
            this.CiudadcomboBox1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadcomboBox1.FormattingEnabled = true;
            this.CiudadcomboBox1.Items.AddRange(new object[] {
            "Puebla",
            "CDMX"});
            this.CiudadcomboBox1.Location = new System.Drawing.Point(334, 242);
            this.CiudadcomboBox1.Name = "CiudadcomboBox1";
            this.CiudadcomboBox1.Size = new System.Drawing.Size(251, 28);
            this.CiudadcomboBox1.TabIndex = 7;
            this.CiudadcomboBox1.Text = "Elige Sucursal";
            // 
            // lblFilas_label5
            // 
            this.lblFilas_label5.AutoSize = true;
            this.lblFilas_label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblFilas_label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilas_label5.Location = new System.Drawing.Point(346, 375);
            this.lblFilas_label5.Name = "lblFilas_label5";
            this.lblFilas_label5.Size = new System.Drawing.Size(211, 27);
            this.lblFilas_label5.TabIndex = 8;
            this.lblFilas_label5.Text = "NÚMERO DE FILAS:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(657, 126);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(95, 34);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(657, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblFilas_label5);
            this.Controls.Add(this.CiudadcomboBox1);
            this.Controls.Add(this.CantidadEnviartextBox2);
            this.Controls.Add(this.NumeroCuentatextBox1);
            this.Controls.Add(this.DatosdataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DatosdataGridView1;
        private System.Windows.Forms.TextBox NumeroCuentatextBox1;
        private System.Windows.Forms.TextBox CantidadEnviartextBox2;
        private System.Windows.Forms.ComboBox CiudadcomboBox1;
        private System.Windows.Forms.Label lblFilas_label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}