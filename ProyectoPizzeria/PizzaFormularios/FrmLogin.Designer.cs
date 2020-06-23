namespace PizzaFormularios
{
    partial class FrmLogin
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btbAceptarDatos = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(108, 115);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(136, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.WordWrap = false;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(197, 185);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(92, 32);
            this.btnLimpiarDatos.TabIndex = 2;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btbAceptarDatos
            // 
            this.btbAceptarDatos.Location = new System.Drawing.Point(84, 185);
            this.btbAceptarDatos.Name = "btbAceptarDatos";
            this.btbAceptarDatos.Size = new System.Drawing.Size(96, 32);
            this.btbAceptarDatos.TabIndex = 2;
            this.btbAceptarDatos.Text = "Aceptar";
            this.btbAceptarDatos.UseVisualStyleBackColor = true;
            this.btbAceptarDatos.Click += new System.EventHandler(this.btbAceptarDatos_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(123, 68);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarios.TabIndex = 5;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 68);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Seleccione Usuario";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 252);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.btbAceptarDatos);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Por Sector";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btbAceptarDatos;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUsuario;
    }
}