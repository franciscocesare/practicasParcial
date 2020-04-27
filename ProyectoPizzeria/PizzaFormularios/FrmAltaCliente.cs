using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using EntidadesPizzeria;

namespace PizzaFormularios
{
    public partial class FrmAltaCliente : Form
    {
       public Cliente cliente;


        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        //construcor de cliente en el formulario
        public FrmAltaCliente(Cliente cliente) : this()
        {
            this.cliente = cliente;
            
        }

        private void btnAceptarDatos_Click(object sender, EventArgs e)
        {

            bool cargoDatos=false;

            cliente = new Cliente(); //creo un nuevo cliente


            if (Validaciones.ValidarCargaStringForms(txtbNombre.Text)
                            && Validaciones.ValidarCargaStringForms(txtbApellido.Text)
                            && Validaciones.ValidarCargaStringForms(txtDomicilio.Text))

            {
                cliente = Cliente.CrearCliente(txtbNombre.Text, txtbApellido.Text, txtDomicilio.Text);

                cargoDatos = true;
                if (cargoDatos)
                {
                    this.DialogResult = DialogResult.OK;//es la respuesta para trabajar con el otro form
                    MessageBox.Show("Cliente Cargado Con exito");
                    this.Close();
                }


            }
            else
                //this.DialogResult = DialogResult.No;
                MessageBox.Show("Faltan Cargar Datos");
                



        }

       

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarSolicitud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitud Cancelada");
            this.Close();
        }
    }
}
