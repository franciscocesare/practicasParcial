using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseDeEventos
{
    public partial class FrmPrincipal : Form
    {
        
            FrmRecibe frmRecibe = new FrmRecibe();

        public FrmPrincipal()
        {
            InitializeComponent();
            frmRecibe = new FrmRecibe();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            FrmEnvia frmEnvia = new FrmEnvia();
            frmEnvia.EnviaMensaje += frmRecibe//el += se le asigna uyn manejador a los eventos
            frmEnvia.Show();

        }

        private void btnRecibe_Click(object sender, EventArgs e)
        {
            frmEnvia.Show();

        }
    }
}
