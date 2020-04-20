using EntidadesPizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaFormularios
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //codigo de lo que va a hacer el boton
        {


        }

       


        //El primer metodo que se ejecuta despues del constructor
        private void FrmPedidos_Load(object sender, EventArgs e) 
        {

        }

        private void btbConfirmarPedido_Click(object sender, EventArgs e)
        {
            object cliente = null;
          //  Pedido pedidoNuevo = new Pedido(Cliente cliente);
            
            //FrmSegundo frmSegundo = new FrmSegundo();
            //if (frmSegundo.ShowDialog() == DialogResult.OK)
            //    MessageBox.Show("Ok");
        }
    }
}
