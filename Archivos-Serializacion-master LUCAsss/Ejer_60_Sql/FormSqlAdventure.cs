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


namespace Ejer_60_Sql
{
    public partial class FormSqlAdventure : Form
    {
           
        SqlConnection miConexion = new SqlConnection(connectionString: @"Server = DESKTOP-VF38COB\SQLEXPRESS; Database=AdventureWorks; Trusted_Connection=True;");
        List<SqlParameter> parameters;
        //DataTable tabla;

        public FormSqlAdventure()
        {
            InitializeComponent();
            parameters = new List<SqlParameter>();

        }

        private void FormSqlAdventure_Load(object sender, EventArgs e)
        {
           // miConexion = new SqlConnection(connectionString: @"Server = DESKTOP-VF38COB\SQLEXPRESS; Database=AdventureWorks; Trusted_Connection=True;");
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            parameters.Clear();

            if (miConexion.State == ConnectionState.Closed)
            {
                if (ManejadorSql.EjecutarConexion(miConexion))
                {
                    MessageBox.Show("Conexion Establecida");
                    progressConection.Value = 100;
                }
                if (miConexion.State == ConnectionState.Open)
                {
                    btnConectar.Enabled = false;
                }
            }

        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            if (miConexion.State == ConnectionState.Closed)
            {
                MessageBox.Show("Primero debe conectarse a la Base de Datos");
            }
            else
            DGconsultas.DataSource = ManejadorSql.EjecutarConsulta("SELECT productid as IDdeProducto, name as NOMBRE_PRODUCTO, productnumber as NumeroDeProducto from Production.product ", null);
        }

        private void DGconsultas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
              int auxIndex;
            if (DGconsultas.CurrentCell.Selected)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                switch (DGconsultas.CurrentCell.OwningColumn.Name)
                {
                    case "IDdeProducto":

                        txt_iD.Text = DGconsultas.CurrentCell.Value.ToString();

                        break;
                    case "NumeroDeProducto":
                        txtNumberProduct.Text = DGconsultas.CurrentCell.Value.ToString();
                        break;

                    case "NOMBRE_PRODUCTO":
                        txtNombre.Text = DGconsultas.CurrentCell.Value.ToString();
                        auxIndex = (int)DGconsultas.CurrentRow.Index;
                        MessageBox.Show(auxIndex.ToString()); //el indice lo trae bien
                        // txtNumberProduct.Text.Replace(txtNumberProduct.Text, DGconsultas.SelectedRows);
                        //    DataGridViewRow { Index = 6 } QUIERO QUE DEL INDICE DE FILA QUE SELECCIONE, ME LLENE LOS OTROS CAMPOS, ASI ME LLENA EL 
                        // DGconsultas.SelectedRows[i].Index.ToString());    DE LA CELDA QUE SELECCIONO
                        break;
                    
                }
            
                //  txtNombre.Text = DGconsultas.Rows.ToString();//.Columns[1].ToString();  //.NAME es el titulo de la columna
              //  MessageBox.Show(DGconsultas.CurrentRow.Cells.ToString()); ////ASI ME IMPRIME EL INDICE POR AHORA

            }
        }
        /*
          command.CommandText = "insert into Production.Product ( Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) values(@nombre, @productnumber, 3,1,0,0,0,0)";
          command.Parameters.Add(new SqlParameter("nombre", txtName.Text));
          command.Parameters.Add(new SqlParameter("productnumber", txtNumber.Text));

         */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //INSERT INTO  Provincia(descripcion, id)
            // VALUES('La Boca', 25)
            parameters.Clear();
            parameters.Add(new SqlParameter("nombre", txtNombre.Text));
            parameters.Add(new SqlParameter("productnumber", txtNumberProduct.Text));

            if (ManejadorSql.EjecutarComando("INSERT INTO Production.Product ( Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) " +
                "values(@nombre, @productnumber, 3,1,0,0,0,0)", parameters) >= 1)
            {
                progressConection.Value = 100;
                MessageBox.Show("Carga exitosa");
                ManejadorSql.EjecutarConexion(miConexion);
                DGconsultas.DataSource = ManejadorSql.EjecutarConsulta("SELECT productid as IDdeProducto, name as NOMBRE_PRODUCTO, productnumber as NumeroDeProducto from Production.product ", null);

            }


        }

    
        private void btnEliminar_Click(object sender, EventArgs e)  ///ver el eliminarrrr
        {
            if (DGconsultas.CurrentCell.Selected)
            {
                parameters.Clear();
                parameters.Add(new SqlParameter("id", (int)DGconsultas.CurrentRow)); /////ver con que hacer aca que tome el valor dentro de la celda de ID

                //WHERE id in (25, 26) OR descripcion like 'LA BOCA'
                if (ManejadorSql.EjecutarComando("DELETE FROM Production.Product WHERE ProductID = @id", parameters) >= 1)
                {
                    progressConection.Value = 100;
                    MessageBox.Show("Se elimino la fila");
                    ManejadorSql.EjecutarConexion(miConexion);
                    DGconsultas.DataSource = ManejadorSql.EjecutarConsulta("Select productid as IDdeProducto, name as NOMBRE_PRODUCTO, productnumber as NumeroDeProducto from Production.product ", null);
                }
            }
        }

        
    }
}
