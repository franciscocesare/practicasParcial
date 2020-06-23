using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Serializacion
{
    class Program
    {

        static void Main(string[] args)
        {
            string file_name = AppDomain.CurrentDomain.BaseDirectory + "SerializacionXml.xml"; //te manda al debug

            Dato p = new Dato("Pepe", 20);

            /*************************************
             * Solo para un dato de tipo objeto  *
             * ***********************************/

            Console.WriteLine("Se crea el objeto 'P'...");

            Console.WriteLine("P.Nombre : {0}", p.nombre);
            Console.WriteLine("P.Edad : {0}", p.edad);

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(file_name, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));
                    ser.Serialize(writer, p);
                }
                Console.WriteLine("Objeto 'P' serializado...");
           
                Console.WriteLine("Deserealizando al objeto 'P'...");
             

                using (XmlTextReader reader = new XmlTextReader(file_name))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));

                    Dato aux = new Dato();

                    aux = (Dato)ser.Deserialize(reader);

                    Console.WriteLine(aux.ToString());

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error al Serializar los Datos");
            }
            finally
            {
                Console.WriteLine("Saliendo del programa...");
                Console.Read();
            }

        }
    }
}
