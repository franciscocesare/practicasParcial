using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direcciones
{
    class Direccion
    {
        int id;
        string calle;
        int numero;
        decimal idLocalidad;
        int piso;
        string departamento;

      

        public int IdDomicilio
        {
            get { return id; }
            set { id = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public decimal IDlocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }



    }

}
