using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                                
namespace EntidadesPizzeria
{
   public class Pizza
    {
        private decimal cantidad;
        private string tipoCoccion;
        private string gusto;

        //constructor
        public Pizza (decimal cantidad, string gusto, string tipoCoccion)
        {
            this.tipoCoccion = tipoCoccion;
            this.gusto = gusto;
            this.cantidad = cantidad;

        }

        private int ValidarCantidad(int cant)
        {
            if (cant != 0 && cant <= 8)
            {
                return cant;
            }
            else
                return 0;
        }
       
        //propiedades
        public decimal Cantidad
        {
            get 
            { 
                return this.cantidad; 
            }
            set 
            {
                this.cantidad = ValidarCantidad((int)value);
            }
        }

        public string TipoCoccion
        {
            get 
            {
                return this.tipoCoccion;
            }
            set 
            {
                this.tipoCoccion = value;            
            }

        }

        public string Gusto
        {
            get
            {
                return this.gusto;
            }
            set
            {
                this.gusto = value;
            }

        }

        public string MostrarPizza()
        {
            //return this.Gusto + this.TipoCoccion + this.Cantidad;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Cantidad.ToString());
            sb.AppendLine("De" + Gusto);
            sb.AppendLine(TipoCoccion);

            return sb.ToString();

        }


        //sobrecarga de igualdad, si una pizza es igual a la otra
        public static bool operator == (Pizza a, Pizza b)
        {
            if  (!(a is null)) //validad que el objeto este creado
                {
                return a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion;
                //esto devuelve True o False
            }

            return false;

        }
        //este es la negacion
        public static bool operator !=(Pizza a, Pizza b)
        {
            return !(a==b);

        }

        //1 comparamos, si son iguales las sumo
        public static bool operator +(Pizza a, Pizza b)
        {
            if (a==b) //si son iguales, despues las sumo
            {
                a.cantidad += b.cantidad; //a la cantidad de piza A le sumamos la canti de B
                return true;
            }
            return false; 
        }


    }



}
