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
            this.components = new System.ComponentModel.Container();
            this.cmbListaClientes = new System.Windows.Forms.ComboBox();
            this.lblClienteExiste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbListaClientes
            // 
            this.cmbListaClientes.FormattingEnabled = true;
            this.cmbListaClientes.Location = new System.Drawing.Point(7, 54);
            this.cmbListaClientes.Name = "cmbListaClientes";
            this.cmbListaClientes.Size = new System.Drawing.Size(120, 21);
            this.cmbListaClientes.Sorted = true;
            this.cmbListaClientes.TabIndex = 2;
            this.cmbListaClientes.SelectedIndexChanged += new System.EventHandler(this.cmbListaClientes_SelectedIndexChanged);
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
            this.lblClienteExiste.Click += new System.EventHandler(this.lblClienteExiste_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Si no esta en la lista";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(7, 115);
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
            this.btnRealizarPedido.Location = new System.Drawing.Point(7, 149);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(125, 71);
            this.btnRealizarPedido.TabIndex = 6;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = false;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(221, 9);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horario";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(185, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // listPedidos
            // 
            this.listPedidos.AllowDrop = true;
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.Location = new System.Drawing.Point(138, 75);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(211, 199);
            this.listPedidos.TabIndex = 9;
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.Location = new System.Drawing.Point(197, 46);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnVerPedidos.TabIndex = 10;
            this.btnVerPedidos.Text = "Ver Pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = true;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 271);
            this.Controls.Add(this.btnVerPedidos);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClienteExiste);
            this.Controls.Add(this.cmbListaClientes);
            this.Name = "FrmClientes";
            this.Text = "Lista Clientes";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbListaClientes;
        private System.Windows.Forms.Label lblClienteExiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.Button btnVerPedidos;
    }
}