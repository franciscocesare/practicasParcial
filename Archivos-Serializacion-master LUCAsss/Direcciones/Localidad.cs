using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direcciones
{
    class Localidad
    {
        private decimal id;
        private decimal idProvincia;
        private string descripcion;

        public Localidad(decimal id, decimal idProv, string descripcion)
        {
            this.id = id;
            this.idProvincia = idProv;
            this.descripcion = descripcion;

        }

        public decimal ID
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public decimal IDProvincia
        {
            get { return this.idProvincia; }
            set { this.idProvincia = value; }
        }


        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public override string ToString()
        {
            return this.descripcion; 
        }



    }
}
