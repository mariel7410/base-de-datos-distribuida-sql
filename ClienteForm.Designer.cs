namespace BD_Banco
{
    partial class ClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.depositos = new System.Windows.Forms.Button();
            this.Retiro = new System.Windows.Forms.Button();
            this.Tranferencia = new System.Windows.Forms.Button();
            this.estado_cuenta = new System.Windows.Forms.Button();
            this.mov_mes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(391, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO APARTADO DE CLIENTES.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // depositos
            // 
            this.depositos.BackColor = System.Drawing.SystemColors.Highlight;
            this.depositos.ForeColor = System.Drawing.Color.White;
            this.depositos.Location = new System.Drawing.Point(301, 212);
            this.depositos.Name = "depositos";
            this.depositos.Size = new System.Drawing.Size(276, 90);
            this.depositos.TabIndex = 1;
            this.depositos.Text = "Depositar Dinero";
            this.depositos.UseVisualStyleBackColor = false;
            this.depositos.Click += new System.EventHandler(this.depositos_Click);
            // 
            // Retiro
            // 
            this.Retiro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Retiro.ForeColor = System.Drawing.Color.White;
            this.Retiro.Location = new System.Drawing.Point(301, 297);
            this.Retiro.Name = "Retiro";
            this.Retiro.Size = new System.Drawing.Size(276, 90);
            this.Retiro.TabIndex = 2;
            this.Retiro.Text = "Retiro de Dinero";
            this.Retiro.UseVisualStyleBackColor = false;
            this.Retiro.Click += new System.EventHandler(this.Retiro_Click);
            // 
            // Tranferencia
            // 
            this.Tranferencia.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tranferencia.ForeColor = System.Drawing.Color.White;
            this.Tranferencia.Location = new System.Drawing.Point(301, 376);
            this.Tranferencia.Name = "Tranferencia";
            this.Tranferencia.Size = new System.Drawing.Size(276, 90);
            this.Tranferencia.TabIndex = 3;
            this.Tranferencia.Text = "Tranferencias ";
            this.Tranferencia.UseVisualStyleBackColor = false;
            this.Tranferencia.Click += new System.EventHandler(this.Tranferencia_Click);
            // 
            // estado_cuenta
            // 
            this.estado_cuenta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.estado_cuenta.ForeColor = System.Drawing.Color.White;
            this.estado_cuenta.Location = new System.Drawing.Point(301, 462);
            this.estado_cuenta.Name = "estado_cuenta";
            this.estado_cuenta.Size = new System.Drawing.Size(276, 90);
            this.estado_cuenta.TabIndex = 4;
            this.estado_cuenta.Text = "Estado de Cuenta";
            this.estado_cuenta.UseVisualStyleBackColor = false;
            this.estado_cuenta.Click += new System.EventHandler(this.estado_cuenta_Click);
            // 
            // mov_mes
            // 
            this.mov_mes.BackColor = System.Drawing.SystemColors.Highlight;
            this.mov_mes.ForeColor = System.Drawing.Color.White;
            this.mov_mes.Location = new System.Drawing.Point(301, 544);
            this.mov_mes.Name = "mov_mes";
            this.mov_mes.Size = new System.Drawing.Size(276, 90);
            this.mov_mes.TabIndex = 5;
            this.mov_mes.Text = "Movimientos Del Mes";
            this.mov_mes.UseVisualStyleBackColor = false;
            this.mov_mes.Click += new System.EventHandler(this.mov_mes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 187);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(599, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(83, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(203, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(599, 462);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(203, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(83, 555);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(203, 79);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1403, 646);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mov_mes);
            this.Controls.Add(this.estado_cuenta);
            this.Controls.Add(this.Tranferencia);
            this.Controls.Add(this.Retiro);
            this.Controls.Add(this.depositos);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button depositos;
        private System.Windows.Forms.Button Retiro;
        private System.Windows.Forms.Button Tranferencia;
        private System.Windows.Forms.Button estado_cuenta;
        private System.Windows.Forms.Button mov_mes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}