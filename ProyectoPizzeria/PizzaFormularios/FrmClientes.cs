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
        
        private static Cliente[] clientes;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        ///ACA QUIERO INICIALIXAR CLIENTES Y ASIGNAR UN PAR DE VALORES 
        private FrmClientes (Cliente cliente): this()
        {
            clientes = new Cliente[10];
            clientes[0] =Cliente.CrearCliente("Mariano","Lopez", "lala 123", "abc123");
            clientes[1] = Cliente.CrearCliente("Jose", "Serrudo", "kakak 452", "ggg444");
            

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
            frmAltaCliente.Show(this); //muestra el formulario
            this.Cursor = Cursors.VSplit;
        }

        private void btnSeleccionarCliente(object sender, EventArgs e)
        {
            

            cmbListaClientes.DataSource = clientes;
            string clienteSelect = Convert.ToString(cmbListaClientes.SelectedIndex);

            //habilito el pass, que lo ingrese y btnAceptar que si esta ok
            //se habilite el clik en realizar pedido
            //txtPassW.Enabled = true;
        }

       

        private void btnAceptarLogin(object sender, EventArgs e)
        {
           
        }

        
    }
}
