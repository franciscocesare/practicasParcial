using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Direcciones
{

    public partial class FrmPrimerSql : Form
    {
        SqlConnection miConexion; //INSTANCIAMOS LA CONEX hace el puente entre net y sql
        List<SqlParameter> parameters;

        List<KeyValuePair<decimal, string>> provincias;
        List<Localidad> localidades;
        DataTable tabla;



        public FrmPrimerSql()
        {
            InitializeComponent();
            provincias = new List<KeyValuePair<decimal, string>>();
            localidades = new List<Localidad>();
            parameters = new List<SqlParameter>();
        }

        private void BtnConectarDesco_Click(object sender, EventArgs e)
        {
            if (miConexion.State == ConnectionState.Closed)
            {
                if (ManejadorSql.EjecutarConexion(miConexion))
                {
                    MessageBox.Show("Conexion Establecida");
                    this.CargarProvincia();

                }
            }
            else if (miConexion.State == ConnectionState.Open && ManejadorSql.EjecutarConexion(miConexion))
            {
               MessageBox.Show("Desconectado");
            }
        }

        private bool ConsultarSql()
        {
            try
            {
                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }

                parameters.Add(new SqlParameter("provFiltro", 2));
                tabla = ManejadorSql.EjecutarConsulta("Select * from provincia = @provFiltro", parameters);
                dataGridConsultas.DataSource = tabla;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

            finally
            {
                if (miConexion.State == ConnectionState.Open)
                {

                    miConexion.Close();

                }
            }

            return true;
        }

        private void FrmPrimerSql_Load(object sender, EventArgs e)
        {

            miConexion = new SqlConnection(@"Server = DESKTOP-VF38COB\SQLEXPRESS; Database=Argentina; Trusted_Connection=True;");

        }



        private void CargarLocalidades() //para parametrizar como objeto y despues llamar al metodo
        {
            SqlCommand comandos = new SqlCommand();
            try
            {
                localidades.Clear();
                comandos.Parameters.Clear();
                miConexion.Open();
                comandos.Connection = miConexion;
                comandos.CommandText = "select * from Localidad where idProvincia = @FILTRO"; //+ ((KeyValuePair<decimal, string>)this.cmbPrivincia.SelectedItem).Key;
                comandos.Parameters.Add(new SqlParameter("FILTRO", ((KeyValuePair<decimal, string>)this.cmbProv.SelectedItem).Key));
                SqlDataReader dr = comandos.ExecuteReader();
                while (dr.Read())
                {
                    localidades.Add(new Localidad((decimal)dr[0], (decimal)dr[1], dr[2].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
            this.cmbLocalidad.DataSource = null;
            this.cmbLocalidad.DataSource = localidades;


        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            FrmPrimerSql direcciones = new FrmPrimerSql();////


            //Comandos = new SqlCommand();     //va a tener un aprop comand text
            //Comandos.Connection = miConexion;       //al comando le decimos a que conexion usar, dnd lo va a ejecutar
            //Comandos.CommandText =

            // ManejadorSql.EjecutarComando("Select * from provincia",);

        }
        /*
         * try
            {
                localidades.Clear();
                command.Parameters.Clear();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Localidad where idProvincia = @COSA"; //+ ((KeyValuePair<decimal, string>)this.cmbPrivincia.SelectedItem).Key;
                command.Parameters.Add(new SqlParameter("COSA", ((KeyValuePair<decimal, string>)this.cmbPrivincia.SelectedItem).Key));
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    localidades.Add(new Localidad((decimal)dr[0], (decimal)dr[1], dr[2].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.cmbLocalidad.DataSource = null;
            this.cmbLocalidad.DataSource = localidades;
         */

        private void CargarProvincia()
        {
           
            parameters.Clear();

            try
            {
                if (miConexion.State!=ConnectionState.Open)
                {
                    miConexion.Open();
                }

                SqlCommand comandos = new SqlCommand();
                comandos.Connection = miConexion;
                //command.Parameters.Add(new SqlParameter("COSA", ((KeyValuePair<decimal, string>)this.cmbPrivincia.SelectedItem).Key));
                comandos.Parameters.Add(new SqlParameter());
                parameters.Add(new SqlParameter("provFiltro", 2));
                tabla = ManejadorSql.EjecutarConsulta("Select * from provincia = @provFiltro", parameters);
               // this.cmbProv.DataSource = tabla; //enlaza al combo con la lista de claveValor, CARGA EL DATA SOURCE DE PROVINCIAs

                this.cmbProv.DataSource = tabla.CreateDataReader();//provincias; //enlaza al combo con la lista de claveValor, CARGA EL DATA SOURCE DE PROVINCIAs
               // this.dataGridConsultas.DataSource = tabla;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); //Message de la excep es una prop por eso no ()

            }

            finally
            {
                miConexion.Close();
            }

           // cmbProv.DataSource = null;
           // cmbProv.DataSource = provincias;
       
        }

        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLocalidades();

        }

        private void FrmPrimerSql_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (miConexion.State == ConnectionState.Open)
            {
                this.miConexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (miConexion.State == ConnectionState.Open)
            {
               // ManejadorSql.EjecutarComando()
            }
        }
    }
}
