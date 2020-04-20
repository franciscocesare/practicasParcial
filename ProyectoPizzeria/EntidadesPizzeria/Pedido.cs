using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public class Pedido
    {
        private Cliente cliente;
        private bool envia;
        private DateTime horaIngreso;
        private DateTime horaRetiro;
        private Pizza[] pizzas; //array de pizza, nombre pizzas. 
                                //guardamos objetos pizza en el array, se instancia en el constr


        //CONSTRUCTORES!!!
        private Pedido(Cliente c)//le paso un cliente por param

        {
            this.cliente = c; //para haber un pedido tiene que haber un cliente
            this.pizzas = new Pizza[8]; //lo inicialiazamos el array, y la cantidad que va a tener
            //this.envia = false;                             //se hace aca, en el constructor!!
        }


        public static implicit operator Pedido(Cliente c)
        {

            Pedido aux = new Pedido(c); //nuevo pedido

            return aux;

        }


        //sobrecargasssss
        //si el cliente ya existe, le cargamos un pedid
        public static bool operator +(Pedido pedido, Pizza pizza)
        {
            //va a buscar en el array de piza existe, y si esta. la suma. sino va al otro For
            for (int i = 0; i < pedido.pizzas.Length; i++)
            {
                if (pedido.pizzas[i] + pizza)
                    return true;

            }
            
            //este bucle agrega si no existe, porque estaa null
            for (int i = 0; i < pedido.pizzas.Length; i++)

            {
                if (pedido.pizzas[i] is null)
                {

                    pedido.pizzas[i] = pizza; //en el indice null le agrego la pizza

                    return true; //la pudo agregar
                }
            }
            return false;
        }
    }


    //un ctor privado que reciba por param un cliente
}

