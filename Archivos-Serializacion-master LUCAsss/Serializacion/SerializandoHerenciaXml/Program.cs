using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace SerializandoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            string ruta = AppDomain.CurrentDomain.BaseDirectory + "SerializandoHerencia.xml";

            
            //Declaro e instancio una lista genérica de tipo ClaseAbstracta
            List<ClaseAbstracta> lista = new List<ClaseAbstracta>();

            //Agrego elementos a la lista (recordar que las clases abstractas no se pueden instanciar)
            lista.Add(new ClaseHija1(1, "Cadena1", 1.1));
            lista.Add(new ClaseHija2(2, "Cadena2", true));
            lista.Add(new ClaseHija1(3, "Cadena3", 2.2));
            lista.Add(new ClaseHija2(4, "Cadena4", false));


            try
            {
                //Utilizo un objeto de tipo XmlTextWriter para poder escribir en un archivo XML.
                using (XmlTextWriter writer = new XmlTextWriter(ruta,
                                                                    System.Text.Encoding.UTF8))
                {
                    //Utilizo un objeto de tipo XmlSerializer para serializar la lista genérica.
                    XmlSerializer ser = new XmlSerializer((typeof(List<ClaseAbstracta>)));
                    //Serializo
                    ser.Serialize(writer, lista);
                }

                Console.WriteLine("Objetos serializados con exito!!!");
             

                Console.WriteLine("Deserializando...");
               
                Console.Clear();

                //Utilizo un objeto de tipo XmlTextReader para poder leer de un archivo XML.
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    //Utilizo un objeto de tipo XmlSerializer para deserializar la lista genérica.
                    XmlSerializer ser = new XmlSerializer((typeof(List<ClaseAbstracta>)));

                    //Deserializo
                    lista = (List<ClaseAbstracta>)ser.Deserialize(reader);
                }


                //Por último recorro la lista genérica y muestro sus elementos
                foreach (ClaseAbstracta item in lista)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error al Serializar los Datos");
            }


            Console.ReadLine();
        }
    }
}
