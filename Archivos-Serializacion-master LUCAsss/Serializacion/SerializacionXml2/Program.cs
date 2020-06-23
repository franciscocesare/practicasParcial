using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace SerializacionXml2
{
    class Program
    {


        static void Main(string[] args)
        {


            string ruta = AppDomain.CurrentDomain.BaseDirectory + "SerializandoHerencia.xml";
            Lista listaDato = new Lista();
            listaDato.Items.Add(new Dato("Juan", 20));
            listaDato.Items.Add(new Dato("Pedro", 30));
            listaDato.Items.Add(new Dato("Martin", 1));
            listaDato.Items.Add(new Dato("Micaela", 28));
            listaDato.Items.Add(new Dato("Graciela", 50));
            listaDato.Items.Add(new Dato("Romina", 9));

            try
            {
                using (XmlTextWriter Escritor = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista)));
                    ser.Serialize(Escritor, listaDato);
                }

                Console.WriteLine("Objetos serializados con exito en {0}", ruta);

                Console.WriteLine("Deserializando...");
                Console.Clear();

                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista)));

                    listaDato = (Lista)ser.Deserialize(reader);
                }
                int i = 0;

                //Se crea un array de la misma cantidad de elementos de la lista
                Dato[] vec = new Dato[listaDato.Items.Count];

                //El metodo 'CopyTo()' copia toda la lista en un array  
                listaDato.Items.CopyTo(vec);

                for (i = 0; i < listaDato.Items.Count; i++)
                {
                    Console.WriteLine(vec[i].ToString());
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
