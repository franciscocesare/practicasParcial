namespace PizzaFormularios
{
    partial class FrmAltaCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTituloFormAlta = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.btnAceptarDatos = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(62, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(54, 106);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 0;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblTituloFormAlta
            // 
            this.lblTituloFormAlta.AutoSize = true;
            this.lblTituloFormAlta.ForeColor = System.Drawing.Color.Red;
            this.lblTituloFormAlta.Location = new System.Drawing.Point(54, 20);
            this.lblTituloFormAlta.Name = "lblTituloFormAlta";
            this.lblTituloFormAlta.Size = new System.Drawing.Size(197, 13);
            this.lblTituloFormAlta.TabIndex = 1;
            this.lblTituloFormAlta.Text = "*Datos a Completar Para Nuevo Cliente*";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(107, 44);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(129, 20);
            this.txtbNombre.TabIndex = 2;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(107, 74);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(129, 20);
            this.txtbApellido.TabIndex = 2;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(107, 103);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(129, 20);
            this.txtDomicilio.TabIndex = 2;
            // 
            // btnAceptarDatos
            // 
            this.btnAceptarDatos.Location = new System.Drawing.Point(82, 156);
            this.btnAceptarDatos.Name = "btnAceptarDatos";
            this.btnAceptarDatos.Size = new System.Drawing.Size(169, 40);
            this.btnAceptarDatos.TabIndex = 3;
            this.btnAceptarDatos.Text = "Click Al Finalizar Solicitud";
            this.btnAceptarDatos.UseVisualStyleBackColor = true;
            this.btnAceptarDatos.Click += new System.EventHandler(this.btnAceptarDatos_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(42, 131);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(107, 128);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(129, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 208);
            this.Controls.Add(this.btnAceptarDatos);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblTituloFormAlta);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAltaCliente";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTituloFormAlta;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button btnAceptarDatos;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}