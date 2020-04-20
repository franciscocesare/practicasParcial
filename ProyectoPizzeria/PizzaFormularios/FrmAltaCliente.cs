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
        Cliente cliente;

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
            Cliente cliente = new Cliente(); //creo un nuevo cliente

            //validaciones para construir con lo cargado un objeto cliente de la clase cliente
            if (Validaciones.ValidarCargaStringForms(txtbNombre.Text)
                            && Validaciones.ValidarCargaStringForms(txtbApellido.Text)
                            && Validaciones.ValidarCargaStringForms(txtDomicilio.Text)
                            && Validaciones.ValidarCargaStringForms(txtContraseña.Text))

            {
                this.DialogResult = DialogResult.OK;

                cliente = Cliente.CrearCliente(txtbNombre.Text, txtbApellido.Text, txtDomicilio.Text, txtContraseña.Text);
                this.Close();            
            }
            else
                this.DialogResult = DialogResult.No;            
           
        }



        //private void VolverAlMenuPrincipal()
        //{
        //    menuPrincipal = new MenuPrincipal(estacionamiento);
        //    menuPrincipal.Show();
        //    this.Hide();
        //}


        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
