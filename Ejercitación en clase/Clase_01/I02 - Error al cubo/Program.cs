using System;

namespace I02___Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
             * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
            string numeroIngresadoStr;
            int numeroEscalar;
            bool sePudoParsearAInt = true;

            int cuadradoDelNumero;
            int cuboDelNumero;
            do
            {
                if (!sePudoParsearAInt)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                else
                {
                    Console.WriteLine("Ingrese un numero: ");
                }
                numeroIngresadoStr = Console.ReadLine();
                sePudoParsearAInt = int.TryParse(numeroIngresadoStr, out numeroEscalar);
                //si me ingresa un numero decimal con "." va bien, si lo hace con "," lo toma entero → (10,10 seria 1010)                    
                //podria validar que no ingrese puntos
            } while (!sePudoParsearAInt);
            cuadradoDelNumero = numeroEscalar;
            cuboDelNumero = numeroEscalar;
            for (int i = 0; i < 2; i++)
            {
                cuadradoDelNumero = cuadradoDelNumero * numeroEscalar
            }

            Console.WriteLine("Hello World!");
        }
    }
}
