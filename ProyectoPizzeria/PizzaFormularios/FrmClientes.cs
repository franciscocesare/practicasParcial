using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPizzeria;

namespace PizzaFormularios
{
    public partial class FrmClientes : Form
    {

      public List <Cliente> clientes;  //lista que va a tener los clientes

       Queue<Pedido> ordenPedidos;
        

        public FrmClientes()
        {
            InitializeComponent();

            ordenPedidos = new Queue<Pedido>();
            clientes = new List<Cliente>();

            clientes.Add(new Cliente("Jose Luis", "Gomez", "Fares 533"));
            clientes.Add(new Cliente("Agustin", "Marchesin", "Arias 123"));
            clientes.Add(new Cliente("Hugo", "Morales", "Juncal 123"));

          // ordenPedidos.Enqueue(new Pedido(clientes[0])); ///aca no me da error, peeero????

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            btnRealizarPedido.Enabled = false;
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            
        }




        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedido = new FrmPedidos((Cliente)clientes[this.cmbListaClientes.SelectedIndex]); //a realizar pedido ya se lo paso con un cliente
            frmPedido.IsMdiContainer = true;
            frmPedido.Show(this);
            this.Cursor = Cursors.VSplit;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {

            FrmAltaCliente frmAltaCliente = new FrmAltaCliente(); //creo un nuevo frmAlta, de la clase FrmAlta
            frmAltaCliente.IsMdiContainer = true; //is mdi container es que abre otro form?
                                                  //  frmAltaCliente.Show(this); //muestra el formulario
                                                  //frmAltaCliente.ShowDialog(); 
                                                  //espera a que complete el otro form para volver
            if (frmAltaCliente.ShowDialog() == DialogResult.OK)

                this.clientes.Add(frmAltaCliente.cliente); //estoy dentro de la clase, pore eso this, EMPEZO A CAGAR 
                                                                //lo suma la lista del frmAlta
                                                                //si ek dialog fue ok, me traigo de frmAlta un cliente

            this.Cursor = Cursors.VSplit;
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
          
           //  ordenPedidos = new Queue<Pedido>();

             ordenPedidos.Enqueue(new Pedido(clientes[0])); ///aca no me da error, peeero????

           // listPedidos.Items.Add();

           // ordenPedidos.Enqueue(new Pedido(a);

            //Random r = new Random();
            //while (pedidos.Count < 0)   //ESTA MAL ESTA VALIDACION
            //{
            //    listPedidos.Items.Add(pedidos);
            //    // Demoro la iteración entre 1 y 3 segundos
            //    //System.Threading.Thread.Sleep(r.Next(1000, 3000));
            //}

        }

       

        public void btnSeleccionarCliente(object sender, EventArgs e)
        { 
            this.cmbListaClientes.Items.Clear();
                  

            foreach (Cliente cliente in this.clientes)
            {
               
               if (!(cliente is null))
                this.cmbListaClientes.Items.Add(cliente.MostrarCliente());
                
            }
           
            

        }

        private void cmbListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbListaClientes.SelectedItem != null)
            {
                btnRealizarPedido.Enabled = true;
                btnAltaCliente.Enabled=false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("HH:MM:ss");
        }

        private void lblClienteExiste_Click(object sender, EventArgs e)
        {

        }
    }
}
