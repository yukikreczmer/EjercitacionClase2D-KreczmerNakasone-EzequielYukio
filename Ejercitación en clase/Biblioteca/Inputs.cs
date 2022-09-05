using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Inputs
    {
        public static int PedirEnteroValido()
        {
            string numeroIngresadoStr;
            int numeroEscalar;
            bool sePudoParsearAInt = true;

            do
            {
                if (!sePudoParsearAInt)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número entero!");
                }
                else
                {
                    Console.WriteLine("Ingrese un numero entero: ");
                }
                numeroIngresadoStr = Console.ReadLine();
                
                sePudoParsearAInt = int.TryParse(numeroIngresadoStr, out numeroEscalar);
            } while (!sePudoParsearAInt);
            return numeroEscalar;
        }
    }
}
