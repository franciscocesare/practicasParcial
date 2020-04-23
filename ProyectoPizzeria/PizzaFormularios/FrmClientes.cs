using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPizzeria;

namespace PizzaFormularios
{
    public partial class FrmClientes : Form
    {

        public static List <Cliente> clientes;  //lista que va a tener los clientes
                                           
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            btnRealizarPedido.Enabled = false;
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }

        static FrmClientes() //la instancio al menos una vez, porque es static
        {
            
           FrmClientes.clientes = new List<Cliente>(); //porque es un ctor las ()

            clientes.Add(new Cliente("Agustin", "Marchesin", "Arias 123"));
            clientes.Add(new Cliente("Jose Luis", "Gomez", "Fares 533"));
            clientes.Add(new Cliente("Hugo", "Morales", "Juncal 123"));
            clientes.Add(new Cliente("Jose", "Sand", "Pavon 5422"));
            clientes.Add(new Cliente("Lautaro", "Acosta", "Bolaños 9928"));
        }

    

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedido = new FrmPedidos();
            frmPedido.IsMdiContainer = true;
            frmPedido.Show(this);
            this.Cursor = Cursors.VSplit;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {

            FrmAltaCliente frmAltaCliente = new FrmAltaCliente(); //creo un nuevo frmAlta, de la clase FrmAlta
            frmAltaCliente.IsMdiContainer = true; //is mdi container es que abre otro form?
                                                  //  frmAltaCliente.Show(this); //muestra el formulario
            frmAltaCliente.ShowDialog(); //espera a que complete el otro form para volver
            this.Cursor = Cursors.VSplit;
        }

        public void btnSeleccionarCliente(object sender, EventArgs e)
        { 
            this.cmbListaClientes.Items.Clear();
                  

            foreach (Cliente item in FrmClientes.clientes)
            {
               
               if (!(item is null))
                this.cmbListaClientes.Items.Add(item.MostrarCliente());
                
            }
           
            

        }

        private void cmbListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbListaClientes.SelectedIndex != 0)
            {
                btnRealizarPedido.Enabled = true;
                btnAltaCliente.Enabled=false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("HH:MM:ss");
        }
    }
}
