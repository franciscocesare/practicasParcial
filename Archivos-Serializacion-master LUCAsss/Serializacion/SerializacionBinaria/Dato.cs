using System;
using System.Collections.Generic;
using System.Text;

namespace SerializacionBinaria
{
    [Serializable]
    class Dato
    {
        public string nombre;
        public int edad;
        private int _dni;

        public Dato()
        {

        }
        public Dato(string name, int age, int dni)
        {
            nombre = name;
            edad = age;
            _dni = dni;
        }

        public override string  ToString()
        {
            string cadena;
            cadena = this.nombre + "\n" + this.edad + "\n" + this._dni;

            return cadena;
        }
    }
}
