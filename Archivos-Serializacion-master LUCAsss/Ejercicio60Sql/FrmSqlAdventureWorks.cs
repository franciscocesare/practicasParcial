using System;
using System.Windows.Forms;
using Direcciones;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio60Sql
{
    public partial class FrmSqlAdventureWorks : Form
    {
        SqlConnection miConexion;
        DataTable tabla;
       


        public FrmSqlAdventureWorks()
        {
            InitializeComponent();
        }

        private void FrmSqlAdventureWorks_Load(object sender, EventArgs e)
        {
           miConexion = new SqlConnection(connectionString: @"Server = DESKTOP-VF38COB\SQLEXPRESS; Database=AdventureWorks; Trusted_Connection=True;");
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            SqlParameter parametros = new SqlParameter();


            if (miConexion.State == ConnectionState.Closed)
            {
                if (ManejadorSql.EjecutarConexion(miConexion))
                {
                    MessageBox.Show("Conexion Establecida");
                   // parametros = 
                   // ManejadorSql.EjecutarConsulta("Select * from Production.product",);

                }
            }
            else if (miConexion.State == ConnectionState.Open && ManejadorSql.EjecutarConexion(miConexion))
            {
                MessageBox.Show("Desconectado");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
