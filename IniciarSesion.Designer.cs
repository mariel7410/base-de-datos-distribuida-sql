namespace BD_Banco
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.EntrarButton = new System.Windows.Forms.Button();
            this.IngresarPrimeraVezLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AtrasButton = new System.Windows.Forms.Button();
            this.MostrarContraseñaCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(123, 77);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(177, 25);
            this.UsuarioTextBox.TabIndex = 0;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTextBox.Location = new System.Drawing.Point(123, 136);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(177, 25);
            this.ContraseñaTextBox.TabIndex = 1;
            // 
            // EntrarButton
            // 
            this.EntrarButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EntrarButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarButton.ForeColor = System.Drawing.Color.White;
            this.EntrarButton.Location = new System.Drawing.Point(61, 219);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(206, 28);
            this.EntrarButton.TabIndex = 2;
            this.EntrarButton.Text = "Entrar";
            this.EntrarButton.UseVisualStyleBackColor = false;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // IngresarPrimeraVezLinkLabel
            // 
            this.IngresarPrimeraVezLinkLabel.AutoSize = true;
            this.IngresarPrimeraVezLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.IngresarPrimeraVezLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarPrimeraVezLinkLabel.Location = new System.Drawing.Point(12, 421);
            this.IngresarPrimeraVezLinkLabel.Name = "IngresarPrimeraVezLinkLabel";
            this.IngresarPrimeraVezLinkLabel.Size = new System.Drawing.Size(48, 20);
            this.IngresarPrimeraVezLinkLabel.TabIndex = 3;
            this.IngresarPrimeraVezLinkLabel.TabStop = true;
            this.IngresarPrimeraVezLinkLabel.Text = "Ayuda";
            this.IngresarPrimeraVezLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IngresarPrimeraVezLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // AtrasButton
            // 
            this.AtrasButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AtrasButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtrasButton.Location = new System.Drawing.Point(239, 314);
            this.AtrasButton.Name = "AtrasButton";
            this.AtrasButton.Size = new System.Drawing.Size(71, 26);
            this.AtrasButton.TabIndex = 7;
            this.AtrasButton.Text = "Atrás";
            this.AtrasButton.UseVisualStyleBackColor = false;
            this.AtrasButton.Click += new System.EventHandler(this.AtrasButton_Click);
            // 
            // MostrarContraseñaCheckBox
            // 
            this.MostrarContraseñaCheckBox.AutoSize = true;
            this.MostrarContraseñaCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MostrarContraseñaCheckBox.BackgroundImage")));
            this.MostrarContraseñaCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarContraseñaCheckBox.ImageKey = "(ninguno)";
            this.MostrarContraseñaCheckBox.Location = new System.Drawing.Point(285, 142);
            this.MostrarContraseñaCheckBox.Name = "MostrarContraseñaCheckBox";
            this.MostrarContraseñaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MostrarContraseñaCheckBox.TabIndex = 8;
            this.MostrarContraseñaCheckBox.UseVisualStyleBackColor = true;
            this.MostrarContraseñaCheckBox.CheckedChanged += new System.EventHandler(this.MostrarContraseñaCheckBox_CheckedChanged);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.MostrarContraseñaCheckBox);
            this.Controls.Add(this.AtrasButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresarPrimeraVezLinkLabel);
            this.Controls.Add(this.EntrarButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button EntrarButton;
        private System.Windows.Forms.LinkLabel IngresarPrimeraVezLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AtrasButton;
        private System.Windows.Forms.CheckBox MostrarContraseñaCheckBox;
    }
}