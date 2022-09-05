using System;
using Biblioteca;

namespace Vista_I01___Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

             bool Validar(int valor, int min, int max)

             valor: dato a validar.
             min: mínimo valor incluido.
             max: máximo valor incluido.
             Pedir al usuario que ingrese 10 números enteros. 
             Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

             Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.*/
            //for(int i = 0; i < args.Length; i++)
            Console.WriteLine(args.Length);
            int enteroIngresado;
            string numeroIngresadoStr;
            bool flagPrimerNumero = true;

            int maxNumeroIngresado = 0;
            int minNumeroIngresado = 0;
            float promedioNumerosIngresados = 0;
            int contadorNumerosIngresados = 0;
            int acumuladorNumerosIngresados = 0;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entero: ");
                    numeroIngresadoStr = Console.ReadLine();
                    //si me ingresa un numero decimal con "." va bien, si lo hace con "," lo toma entero → (10,10 seria 1010)                    
                    //podria validar que no ingrese puntos
                } while (!int.TryParse(numeroIngresadoStr, out enteroIngresado) || !Validador.Validar(enteroIngresado, -100, 100));
                
                if (flagPrimerNumero || enteroIngresado > maxNumeroIngresado)
                {
                    maxNumeroIngresado = enteroIngresado;
                }

                if (flagPrimerNumero || enteroIngresado < minNumeroIngresado)
                {
                    minNumeroIngresado = enteroIngresado;
                }
                flagPrimerNumero = false;

                contadorNumerosIngresados++;
                acumuladorNumerosIngresados += enteroIngresado;
                promedioNumerosIngresados = acumuladorNumerosIngresados / (float)contadorNumerosIngresados;

            }
            Console.WriteLine($"El valor máximo ingresado es: {maxNumeroIngresado}");
            Console.WriteLine($"El valor mínimo ingresado es: {minNumeroIngresado}");
            Console.WriteLine($"El promedioNumerosIngresados de los números ingresados es: {promedioNumerosIngresados}");

        }
    }
}
