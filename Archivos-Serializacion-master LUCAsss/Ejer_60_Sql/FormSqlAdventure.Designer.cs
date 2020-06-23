namespace Ejer_60_Sql
{
    partial class FormSqlAdventure
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGconsultas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txt_iD = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.progressConection = new System.Windows.Forms.ProgressBar();
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            this.txtNumberProduct = new System.Windows.Forms.TextBox();
            this.lbliDprod = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumberProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGconsultas
            // 
            this.DGconsultas.AllowUserToAddRows = false;
            this.DGconsultas.AllowUserToDeleteRows = false;
            this.DGconsultas.AllowUserToResizeRows = false;
            this.DGconsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGconsultas.Location = new System.Drawing.Point(12, 109);
            this.DGconsultas.MultiSelect = false;
            this.DGconsultas.Name = "DGconsultas";
            this.DGconsultas.ReadOnly = true;
            this.DGconsultas.RowHeadersVisible = false;
            this.DGconsultas.Size = new System.Drawing.Size(786, 339);
            this.DGconsultas.TabIndex = 0;
            this.DGconsultas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGconsultas_CellMouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(310, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(410, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(514, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 12);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(86, 52);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txt_iD
            // 
            this.txt_iD.Location = new System.Drawing.Point(298, 29);
            this.txt_iD.Name = "txt_iD";
            this.txt_iD.Size = new System.Drawing.Size(111, 20);
            this.txt_iD.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(444, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // progressConection
            // 
            this.progressConection.Enabled = false;
            this.progressConection.Location = new System.Drawing.Point(12, 70);
            this.progressConection.Name = "progressConection";
            this.progressConection.Size = new System.Drawing.Size(180, 33);
            this.progressConection.TabIndex = 3;
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.Location = new System.Drawing.Point(147, 12);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(118, 33);
            this.btnMostrarTabla.TabIndex = 1;
            this.btnMostrarTabla.Text = "Mostrar em Tabla";
            this.btnMostrarTabla.UseVisualStyleBackColor = true;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // txtNumberProduct
            // 
            this.txtNumberProduct.Location = new System.Drawing.Point(590, 29);
            this.txtNumberProduct.Name = "txtNumberProduct";
            this.txtNumberProduct.Size = new System.Drawing.Size(110, 20);
            this.txtNumberProduct.TabIndex = 2;
            // 
            // lbliDprod
            // 
            this.lbliDprod.AutoSize = true;
            this.lbliDprod.Location = new System.Drawing.Point(295, 9);
            this.lbliDprod.Name = "lbliDprod";
            this.lbliDprod.Size = new System.Drawing.Size(53, 13);
            this.lbliDprod.TabIndex = 4;
            this.lbliDprod.Text = "IdProduct";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(441, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name Product";
            // 
            // lblNumberProduct
            // 
            this.lblNumberProduct.AutoSize = true;
            this.lblNumberProduct.Location = new System.Drawing.Point(587, 9);
            this.lblNumberProduct.Name = "lblNumberProduct";
            this.lblNumberProduct.Size = new System.Drawing.Size(84, 13);
            this.lblNumberProduct.TabIndex = 4;
            this.lblNumberProduct.Text = "Product Number";
            // 
            // FormSqlAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberProduct);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbliDprod);
            this.Controls.Add(this.progressConection);
            this.Controls.Add(this.txtNumberProduct);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txt_iD);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DGconsultas);
            this.Name = "FormSqlAdventure";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSqlAdventure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGconsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGconsultas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txt_iD;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ProgressBar progressConection;
        private System.Windows.Forms.Button btnMostrarTabla;
        private System.Windows.Forms.TextBox txtNumberProduct;
        private System.Windows.Forms.Label lbliDprod;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumberProduct;
    }
}

