namespace ClaseDeEventos
{
    partial class FrmPrincipal
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
            this.btnEnvia = new System.Windows.Forms.Button();
            this.btnRecibe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvia
            // 
            this.btnEnvia.Location = new System.Drawing.Point(103, 72);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(171, 83);
            this.btnEnvia.TabIndex = 0;
            this.btnEnvia.Text = "FrmEnvia";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // btnRecibe
            // 
            this.btnRecibe.Location = new System.Drawing.Point(103, 188);
            this.btnRecibe.Name = "btnRecibe";
            this.btnRecibe.Size = new System.Drawing.Size(171, 83);
            this.btnRecibe.TabIndex = 0;
            this.btnRecibe.Text = "FrmRecibe";
            this.btnRecibe.UseVisualStyleBackColor = true;
            this.btnRecibe.Click += new System.EventHandler(this.btnRecibe_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecibe);
            this.Controls.Add(this.btnEnvia);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Button btnRecibe;
    }
}