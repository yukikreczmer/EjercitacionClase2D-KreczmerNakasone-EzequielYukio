using System;

namespace Clase01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kreczmer Nakasone Ezequiel Yukio
             * Ingresar 5 números por consola, guardándolos en una variable escalar.
             * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedioNumerosIngresados*/
            int cantNumerosPedidos = 5;

            string numeroIngresadoStr;
            float numeroEscalar;
            bool sePudoParsearAFloat;
            bool flagPrimerNumero = true;

            float maxNumeroIngresado = 0;
            float minNumeroIngresado = 0;
            float promedioNumerosIngresados = 0;
            int contadorNumerosIngresados = 0;
            float acumuladorNumerosIngresados = 0;

            for (int i = 0; i < cantNumerosPedidos; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: ");
                    numeroIngresadoStr = Console.ReadLine();
                    sePudoParsearAFloat = float.TryParse(numeroIngresadoStr, out numeroEscalar);
                    //si me ingresa un numero decimal con "." va bien, si lo hace con "," lo toma entero → (10,10 seria 1010)                    
                    //podria validar que no ingrese puntos
                } while (!sePudoParsearAFloat);

                if (flagPrimerNumero || numeroEscalar > maxNumeroIngresado)
                {
                    maxNumeroIngresado = numeroEscalar;
                }

                if (flagPrimerNumero || numeroEscalar < minNumeroIngresado)
                {
                    minNumeroIngresado = numeroEscalar;
                }
                flagPrimerNumero = false;

                contadorNumerosIngresados++;
                acumuladorNumerosIngresados += numeroEscalar;
                promedioNumerosIngresados = acumuladorNumerosIngresados / (float)contadorNumerosIngresados;
            }

            Console.WriteLine($"El valor máximo ingresado es: {maxNumeroIngresado}");
            Console.WriteLine($"El valor mínimo ingresado es: {minNumeroIngresado}");
            Console.WriteLine($"El promedioNumerosIngresados de los números ingresados es: {promedioNumerosIngresados}");
        }
    }
}
