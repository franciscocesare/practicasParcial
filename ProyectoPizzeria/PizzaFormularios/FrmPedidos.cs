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
        private int cantidadPizzas = 0;

        public FrmPedidos(Cliente cliente)
        {

            pedido = cliente;
            InitializeComponent();
        }




        //El primer metodo que se ejecuta despues del constructor
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            //CARGA EL COMBOBOX CON LA LISTA
            this.cmbGustos.DataSource = Enum.GetNames(typeof(SaboresPizzas));
            this.cmbCoccion.DataSource = Enum.GetNames(typeof(TipoCoccion));
            btbConfirmarPedido.Enabled = false;



        }

        private void btnAgregarPizza_Click(object sender, EventArgs e)
        {
           
           // pizza = new Pizza(numCantidad.Value, cmbGustos.Text, cmbCoccion.Text);

            this.pizza.Gusto = cmbGustos.Text;
            this.pizza.TipoCoccion = cmbCoccion.Text;
            this.pizza.Cantidad = numCantidad.Value;

            //ESTEEEE esta al pedo???? manda a cona
            pizza = new Pizza(pizza.Cantidad, pizza.Gusto, pizza.TipoCoccion);


            cantidadPizzas += (int)pizza.Cantidad;

            if (cantidadPizzas <= 8 && this.pedido + pizza) //&& pedido + pizzas
            {

                listPedidos.Items.Add(pizza.MostrarPizza());
                
            }

            if (cantidadPizzas >= 9)
            {
                MessageBox.Show("LIMITE 8 pizzas por envio");
                cantidadPizzas -= (int)pizza.Cantidad;
            }

            btbConfirmarPedido.Enabled = true;
        }

        private void btbConfirmarPedido_Click(object sender, EventArgs e)
        {

            pedido.Envio = this.rdbtnEnvio.Checked;
            pedido.HoraIngreso = DateTime.Now;
            

            


            this.DialogResult = DialogResult.OK;
            
            this.Cursor = Cursors.VSplit;

            


        }

       

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelando pedido", "Cierre de Pedido", MessageBoxButtons.YesNo) == DialogResult.OK)
            {

                this.Close();

            }


        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            numCantidad.Minimum = 1;
            numCantidad.Maximum = 8;


            //int cantidad;

        }


    }
}
