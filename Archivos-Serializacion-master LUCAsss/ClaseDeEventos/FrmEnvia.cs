using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClaseDeEventos
{
    public delegate void CargarMensaje(string palabra); //firma del evento, con mayusculas los Delegados
    
    public partial class FrmEnvia : Form
    {
        public event CargarMensaje EnviaMensaje; //se podria decir que es un tipo de dato

        public FrmEnvia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text != string.Empty)
                EnviaMensaje.Invoke(txtTexto.Text);//hay que pasarle la palabra para q la reciba el otro
                                    //el invoke es opcional funciona igual
        }
    }
}
