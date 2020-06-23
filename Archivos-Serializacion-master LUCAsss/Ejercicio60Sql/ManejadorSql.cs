using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Direcciones
{
    /*
     * manejador en Static xq no se instancia
     * se ejecuta una sola vez
     */
    static class ManejadorSql
    { 
        static SqlConnection connection;
        static SqlCommand command; //lo creo en cada metodo,  para que no quede cargado

        static ManejadorSql() //en el construct instanciamos  conexion
        {
            connection = new SqlConnection(@"Server = DESKTOP-VF38COB\SQLEXPRESS; Database=Argentina; Trusted_Connection=True;"); //datos conexion podrir ir aqui como parametro, sin boton conectar desconectyr
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
        }

        public static bool EjecutarConexion(SqlConnection datosConexion)
        {
            try
            {
                SqlConnection connection = datosConexion; //permite establecer la conexion de BD que vas a utilizar
                SqlCommand command = new SqlCommand();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    command.Connection = connection; ////FALLA EN EL PUENTECITOUUU
                }

                else if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            return true;
        }

        public static int EjecutarComando(string orden, List<SqlParameter> parametros)//ret un int si pudo o no
        {
            int retorno = -1;

            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = orden; //esto va a venir del FRM 


                if (parametros != null)
                {
                    foreach (SqlParameter item in parametros) //recorre la lista y a cada uno le agrega parametro
                    {
                        command.Parameters.Add(item);
                    }

                }

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                retorno = command.ExecuteNonQuery(); //devuelve un int de cuantas rows afecto. 1 o maS pudo, -1 no
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return retorno;
        }

        public static DataTable EjecutarConsulta(string consulta, List<SqlParameter> parametros)
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand command = new SqlCommand();  /////LLEGA CERRADA la consulta me parece
                command.Connection = connection;
                SqlDataReader dataReader;

                command.Connection = connection;
                command.CommandText = consulta; //esta la trae de quien la invoque

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // if (parametros != null)
                //  {
                foreach (SqlParameter item in parametros) //recorre la lista y a cada uno le agrega parametro
                {
                    command.Parameters.Add(item);
                }

                // }



                dataReader = command.ExecuteReader(); //devuelve un int de cuantas rows afecto
                tabla.Load(dataReader); //carga la tabla con lo que leyo         
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)

                    connection.Close();

            }

            return tabla;
        }



    }
}
