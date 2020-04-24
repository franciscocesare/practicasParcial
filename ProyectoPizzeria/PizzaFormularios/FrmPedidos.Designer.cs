namespace PizzaFormularios
{
    partial class FrmPedidos
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
            this.btbConfirmarPedido = new System.Windows.Forms.Button();
            this.lblGustoPizza = new System.Windows.Forms.Label();
            this.lblCoccion = new System.Windows.Forms.Label();
            this.rdbtnEnvio = new System.Windows.Forms.RadioButton();
            this.rdbtntRetiro = new System.Windows.Forms.RadioButton();
            this.grbDelivery = new System.Windows.Forms.GroupBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.lblCompletarPedido = new System.Windows.Forms.Label();
            this.cmbCoccion = new System.Windows.Forms.ComboBox();
            this.cmbGustos = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.grbDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btbConfirmarPedido
            // 
            this.btbConfirmarPedido.Location = new System.Drawing.Point(17, 225);
            this.btbConfirmarPedido.Name = "btbConfirmarPedido";
            this.btbConfirmarPedido.Size = new System.Drawing.Size(106, 31);
            this.btbConfirmarPedido.TabIndex = 0;
            this.btbConfirmarPedido.Text = "Confirmar Pedido";
            this.btbConfirmarPedido.UseVisualStyleBackColor = true;
            this.btbConfirmarPedido.Click += new System.EventHandler(this.btbConfirmarPedido_Click);
            // 
            // lblGustoPizza
            // 
            this.lblGustoPizza.AutoSize = true;
            this.lblGustoPizza.Location = new System.Drawing.Point(1, 57);
            this.lblGustoPizza.Name = "lblGustoPizza";
            this.lblGustoPizza.Size = new System.Drawing.Size(88, 13);
            this.lblGustoPizza.TabIndex = 1;
            this.lblGustoPizza.Text = "Que gusto desea";
            // 
            // lblCoccion
            // 
            this.lblCoccion.AutoSize = true;
            this.lblCoccion.Location = new System.Drawing.Point(4, 93);
            this.lblCoccion.Name = "lblCoccion";
            this.lblCoccion.Size = new System.Drawing.Size(85, 13);
            this.lblCoccion.TabIndex = 1;
            this.lblCoccion.Text = "Tipo de Coccion";
            // 
            // rdbtnEnvio
            // 
            this.rdbtnEnvio.AutoSize = true;
            this.rdbtnEnvio.Location = new System.Drawing.Point(25, 17);
            this.rdbtnEnvio.Name = "rdbtnEnvio";
            this.rdbtnEnvio.Size = new System.Drawing.Size(52, 17);
            this.rdbtnEnvio.TabIndex = 2;
            this.rdbtnEnvio.TabStop = true;
            this.rdbtnEnvio.Text = "Envio";
            this.rdbtnEnvio.UseVisualStyleBackColor = true;
            // 
            // rdbtntRetiro
            // 
            this.rdbtntRetiro.AutoSize = true;
            this.rdbtntRetiro.Location = new System.Drawing.Point(83, 17);
            this.rdbtntRetiro.Name = "rdbtntRetiro";
            this.rdbtntRetiro.Size = new System.Drawing.Size(79, 17);
            this.rdbtntRetiro.TabIndex = 2;
            this.rdbtntRetiro.TabStop = true;
            this.rdbtntRetiro.Text = "Take Away";
            this.rdbtntRetiro.UseVisualStyleBackColor = true;
            // 
            // grbDelivery
            // 
            this.grbDelivery.Controls.Add(this.rdbtntRetiro);
            this.grbDelivery.Controls.Add(this.rdbtnEnvio);
            this.grbDelivery.Location = new System.Drawing.Point(12, 169);
            this.grbDelivery.Name = "grbDelivery";
            this.grbDelivery.Size = new System.Drawing.Size(180, 50);
            this.grbDelivery.TabIndex = 3;
            this.grbDelivery.TabStop = false;
            this.grbDelivery.Text = "Delivery o Take Away";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(235, 225);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(106, 31);
            this.btnCancelarPedido.TabIndex = 0;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // lblCompletarPedido
            // 
            this.lblCompletarPedido.AutoSize = true;
            this.lblCompletarPedido.BackColor = System.Drawing.Color.Beige;
            this.lblCompletarPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompletarPedido.ForeColor = System.Drawing.Color.Black;
            this.lblCompletarPedido.Location = new System.Drawing.Point(12, 9);
            this.lblCompletarPedido.Name = "lblCompletarPedido";
            this.lblCompletarPedido.Size = new System.Drawing.Size(147, 15);
            this.lblCompletarPedido.TabIndex = 5;
            this.lblCompletarPedido.Text = "Vamos a Completar el Pedido";
            // 
            // cmbCoccion
            // 
            this.cmbCoccion.FormattingEnabled = true;
            this.cmbCoccion.Items.AddRange(new object[] {
            "Piedra\t",
            "Molde",
            "Indistinto"});
            this.cmbCoccion.Location = new System.Drawing.Point(95, 90);
            this.cmbCoccion.Name = "cmbCoccion";
            this.cmbCoccion.Size = new System.Drawing.Size(120, 21);
            this.cmbCoccion.TabIndex = 6;
            this.cmbCoccion.Text = "Coccion";
            // 
            // cmbGustos
            // 
            this.cmbGustos.FormattingEnabled = true;
            this.cmbGustos.Items.AddRange(new object[] {
            "Muzzarella",
            "Napolitana",
            "Especial",
            "Margarita"});
            this.cmbGustos.Location = new System.Drawing.Point(95, 54);
            this.cmbGustos.Name = "cmbGustos";
            this.cmbGustos.Size = new System.Drawing.Size(120, 21);
            this.cmbGustos.TabIndex = 6;
            this.cmbGustos.Text = "Sabores";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(96, 119);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(62, 20);
            this.numCantidad.TabIndex = 0;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(37, 121);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.Location = new System.Drawing.Point(221, 16);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(180, 173);
            this.listPedidos.TabIndex = 3;
            // 
            // FrmPedidos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(413, 298);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cmbGustos);
            this.Controls.Add(this.cmbCoccion);
            this.Controls.Add(this.lblCompletarPedido);
            this.Controls.Add(this.grbDelivery);
            this.Controls.Add(this.lblCoccion);
            this.Controls.Add(this.lblGustoPizza);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btbConfirmarPedido);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidos";
            this.Text = "Pedidos Clientes";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.grbDelivery.ResumeLayout(false);
            this.grbDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbConfirmarPedido;
        private System.Windows.Forms.Label lblGustoPizza;
        private System.Windows.Forms.Label lblCoccion;
        private System.Windows.Forms.RadioButton rdbtnEnvio;
        private System.Windows.Forms.RadioButton rdbtntRetiro;
        private System.Windows.Forms.GroupBox grbDelivery;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label lblCompletarPedido;
        private System.Windows.Forms.ComboBox cmbCoccion;
        private System.Windows.Forms.ComboBox cmbGustos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListBox listPedidos;
    }
}