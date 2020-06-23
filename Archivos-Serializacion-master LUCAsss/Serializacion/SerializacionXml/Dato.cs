using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serializacion
{
   [Serializable]
   public class Dato
    {
        public string nombre;
        public int edad;

       public Dato()
       {

       }
       public Dato(string name, int age)
       {
           nombre = name;
           edad = age;
       }



       public override string ToString()
       {
           string cadena;
           cadena = this.nombre + "\n" + this.edad;

           return cadena;
       }
   }
}
