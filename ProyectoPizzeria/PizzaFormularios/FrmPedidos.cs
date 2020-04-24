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

        private Pedido pedido;
        private Pizza pizza;
        private int cantidadPizzas;

        public FrmPedidos(Cliente cliente)
        {
            InitializeComponent();
            pedido = cliente;


        }

        public FrmPedidos()
        {
          
        }




        //El primer metodo que se ejecuta despues del constructor
        private void FrmPedidos_Load(object sender, EventArgs e) 
        {
            //CARGA EL COMBOBOX CON LA LISTA
            this.cmbGustos.DataSource = Enum.GetNames(typeof(SaboresPizzas));
            this.cmbCoccion.DataSource = Enum.GetNames(typeof(TipoCoccion));

        }

        private void btbConfirmarPedido_Click(object sender, EventArgs e)
        {
            listPedidos.Items.Clear();
            pizza = new Pizza(numCantidad.Value,cmbGustos.Text,cmbCoccion.Text);

            pedido.Envio=this.rdbtnEnvio.Checked;
            pedido.HoraIngreso = DateTime.Now;
            cantidadPizzas = this.numCantidad.DecimalPlaces;
            listPedidos.Items.Add(pedido.Cliente.MostrarCliente());

            if (cmbGustos.SelectedIndex != 0 && cmbCoccion.SelectedIndex != 0 &&
               numCantidad.Value != 0)

               //  pizza = new Pizza(pizza.Cantidad, pizza.Gusto, pizza.TipoCoccion);
                MessageBox.Show("PEDIDO COMPLETADO" );
           

        
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

            //int cantidad;

        }
    }
}
