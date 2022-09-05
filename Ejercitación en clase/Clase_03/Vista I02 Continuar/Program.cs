using System;
using Biblioteca;


namespace Vista_I02_Continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
             * "¿Desea continuar? (S/N)".

            Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/
            int numero1;
            int numero2;
            string numeroIngresado;
            int resultado;
            char respuesta;
            do
            {
                Console.WriteLine("Ingresará 2 numeros enteros para que se sumen: ");
                numero1 = Inputs.PedirEnteroValido();
                numero2 = Inputs.PedirEnteroValido();
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de la suma es: " + resultado);
                Console.WriteLine("¿Desea ingresar otros 2 números para sumar? (S/N)");
                respuesta = Console.ReadKey().KeyChar;
            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}
