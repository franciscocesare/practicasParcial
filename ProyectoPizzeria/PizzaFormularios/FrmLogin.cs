
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPizzeria;

namespace PizzaFormularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbUsuarios.Items.Clear();
            cmbUsuarios.DataSource = Enum.GetValues(typeof(Epuestos));
           
        }

        private static string ValidarSector(string sector)
        {
            string validado = "PedidosYcaja";

            if (sector == "Cocina")
            {
                validado = "Cocina";
            }
            if (sector == "Gerencia")
            {
                validado = "Gerencia";
            }

            return validado;
        }

        private void btbAceptarDatos_Click(object sender, EventArgs e)
        {
          //  string validarIngreso;

           if (cmbUsuarios.SelectedItem!=null && txtContraseña.Text!=null)
            {
                switch (ValidarSector(this.cmbUsuarios.SelectedItem.ToString()))
                {
                    case "PedidosYcaja":
                        
                            if(txtContraseña.Text=="pedidos123")
                            {

                               MessageBox.Show("Bienvenido Pedidos!");
                               FrmClientes frmClientes = new FrmClientes();
                               frmClientes.Show(this);



                        }
                            break;
                        
                    case "Gerencia":
                        
                            if (txtContraseña.Text == "gerencia123")
                            {
                                MessageBox.Show("Bienvenido Gerente!");
                            }
                            break;
                        
                    case "Cocina":
                        
                            if (txtContraseña.Text == "cocina123")
                            {
                                MessageBox.Show("Bienvenido cocina!");
                            }
                            break;
                        
                   
                }


            }

            

        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
