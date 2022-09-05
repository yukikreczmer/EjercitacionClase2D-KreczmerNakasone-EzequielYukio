using System;

namespace Biblioteca
{
    public class Validador
    {

        public static bool Validar(int valor, int min, int max)
        {
            return (valor >= min && valor <= max);
        }

        public static bool ValidarRespuesta(char respuesta)
        {
            return char.ToUpper(respuesta) == 'S' ;
        }

    }
}
