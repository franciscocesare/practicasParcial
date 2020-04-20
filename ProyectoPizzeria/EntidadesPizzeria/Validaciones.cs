using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {


        public static string ValidarCargaString(string s, string mensajeError)
        {
            while (s == string.Empty)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                s = Console.ReadLine();
            }
            return s;
        }

        /*public static string ValidarCargaDomicilio(string aux, string mensajeError) //Por ej Patente
        {
            int auxInt=0;
            while (aux == string.Empty || aux.Contains(auxInt) ) //que no este vacio o no tenga numeros en el domicilio
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                aux = Console.ReadLine();
            }
            return aux;
        }
        */


        public static string ValidarCargaStringLimitado(string aux, string mensajeError) //Por ej Patente
        {
            while (aux == string.Empty || aux.Length < 6 || aux.Length > 8) //que no este vacio, o que tenga menos de 6 o que tenga mas de 8
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                aux = Console.ReadLine();
            }
            return aux;
        }

        public static int ValidarCargaEntero(string s, string mensajeError, int max, int min)
        {
            int numeroARetornar = 0;
            while (!(int.TryParse(s, out numeroARetornar)) || numeroARetornar < min || numeroARetornar > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                s = Console.ReadLine();
            }
            return numeroARetornar;
        }

        public static int ValidarCargaDni(string aux, string mensajeError)
        {
            int dni = 0;
            while (!(int.TryParse(aux, out dni)) || aux.Length<7 || aux.Length>8)
            { 
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine(mensajeError);
                   Console.ResetColor();
              
                aux = Console.ReadLine();
            }

            return dni;
        }

        public static double ValidarCargaDouble(string s, string mensajeError, double max, double min)
        {
            double numeroARetornar = 0;
            while (!(double.TryParse(s, out numeroARetornar)) || numeroARetornar < min || numeroARetornar > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensajeError);
                Console.ResetColor();
                s = Console.ReadLine();
            }
            return numeroARetornar;
        }

        public static bool ValidarSioNo(string v)
        {
            string respuesta = String.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(v + " SI en caso afirmativo, NO en caso negativo");
            Console.ResetColor();
            respuesta = Console.ReadLine().ToUpper();

            while (respuesta != "SI" && respuesta != "NO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error, dato ingresado no valido");
                Console.WriteLine(v + " SI en caso afirmativo, NO en caso negativo");
                Console.ResetColor();

                respuesta = Console.ReadLine().ToUpper();
            }

            if (respuesta == "SI")
                return true;
            return false;
        }

        public static bool ValidarCargaEnteroForms(string s, int max, int min)
        {
            return (int.TryParse(s, out int numeroARetornar) && numeroARetornar > min && numeroARetornar < max);
        }
        public static bool ValidarCargaStringForms(string s)
        {
            return !(string.IsNullOrEmpty(s));
        }


    }
}
