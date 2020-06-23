using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace SerializacionBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_name = AppDomain.CurrentDomain.BaseDirectory + "SerializacionBinaria.dat";
            Dato dato = new Dato("Juan", 15, 22222222);

            BinaryFormatter ser = new BinaryFormatter();

            FileStream fs = new FileStream(file_name, FileMode.Create);
            try
            {
                ser.Serialize(fs, dato);
                
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);

            }
            finally
            {
                fs.Close();
            }

            FileStream fst = new FileStream(file_name, FileMode.Open);
            try
            {

                Dato aux = new Dato();

                //aux = (Dato)ser.Deserialize(fst);
                aux = (Dato)ser.Deserialize(fst);

                Console.WriteLine(aux.ToString());
                Console.ReadLine();
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fst.Close();
            }
        }
    }
}
