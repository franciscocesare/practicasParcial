namespace PizzaFormularios
{
    partial class FrmClientes
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
            this.BtnAceptCliente = new System.Windows.Forms.Button();
            this.cmbListaClientes = new System.Windows.Forms.ComboBox();
            this.lblClienteExiste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.txtPassW = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAceptCliente
            // 
            this.BtnAceptCliente.Location = new System.Drawing.Point(168, 89);
            this.BtnAceptCliente.Name = "BtnAceptCliente";
            this.BtnAceptCliente.Size = new System.Drawing.Size(73, 23);
            this.BtnAceptCliente.TabIndex = 1;
            this.BtnAceptCliente.Text = "Aceptar";
            this.BtnAceptCliente.UseVisualStyleBackColor = true;
            this.BtnAceptCliente.Click += new System.EventHandler(this.btnAceptarLogin);
            // 
            // cmbListaClientes
            // 
            this.cmbListaClientes.FormattingEnabled = true;
            this.cmbListaClientes.Location = new System.Drawing.Point(7, 54);
            this.cmbListaClientes.Name = "cmbListaClientes";
            this.cmbListaClientes.Size = new System.Drawing.Size(120, 21);
            this.cmbListaClientes.Sorted = true;
            this.cmbListaClientes.TabIndex = 2;
            this.cmbListaClientes.Click += new System.EventHandler(this.btnSeleccionarCliente);
            // 
            // lblClienteExiste
            // 
            this.lblClienteExiste.AutoSize = true;
            this.lblClienteExiste.Location = new System.Drawing.Point(4, 38);
            this.lblClienteExiste.Name = "lblClienteExiste";
            this.lblClienteExiste.Size = new System.Drawing.Size(112, 13);
            this.lblClienteExiste.TabIndex = 3;
            this.lblClienteExiste.Text = "Seleccione su nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Aun no eres Cliente?";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(22, 115);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(87, 23);
            this.btnAltaCliente.TabIndex = 5;
            this.btnAltaCliente.Text = "Cliente Nuevo";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRealizarPedido.FlatAppearance.BorderSize = 4;
            this.btnRealizarPedido.ForeColor = System.Drawing.Color.Navy;
            this.btnRealizarPedido.Location = new System.Drawing.Point(84, 160);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(76, 51);
            this.btnRealizarPedido.TabIndex = 6;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = false;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // txtPassW
            // 
            this.txtPassW.Enabled = false;
            this.txtPassW.Location = new System.Drawing.Point(168, 55);
            this.txtPassW.Name = "txtPassW";
            this.txtPassW.PasswordChar = '*';
            this.txtPassW.Size = new System.Drawing.Size(120, 20);
            this.txtPassW.TabIndex = 7;
            this.txtPassW.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(165, 38);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 232);
            this.Controls.Add(this.txtPassW);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblClienteExiste);
            this.Controls.Add(this.cmbListaClientes);
            this.Controls.Add(this.BtnAceptCliente);
            this.Name = "FrmClientes";
            this.Text = "Lista Clientes";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAceptCliente;
        private System.Windows.Forms.ComboBox cmbListaClientes;
        private System.Windows.Forms.Label lblClienteExiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.TextBox txtPassW;
        private System.Windows.Forms.Label lblContraseña;
    }
}