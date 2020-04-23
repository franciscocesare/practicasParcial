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

        
       

        //El primer metodo que se ejecuta despues del constructor
        private void FrmPedidos_Load(object sender, EventArgs e) 
        {
            //CARGA EL COMBOBOX CON LA LISTA
            cmbGustos.DataSource = Enum.GetNames(typeof(SaboresPizzas));
            cmbCoccion.DataSource = Enum.GetNames(typeof(TipoCoccion));
        }

        private void btbConfirmarPedido_Click(object sender, EventArgs e)
        {
            string sabor;
            string tipoCoccion;
            int cantidad;

            sabor = cmbGustos.SelectedItem.ToString();
            tipoCoccion = cmbCoccion.SelectedItem.ToString();
            //cantidad = numCantidad.Value();

            
        
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelando pedido");
            this.Close();
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            numCantidad.Minimum = 1;
            numCantidad.Maximum = 8;
        }
    }
}
