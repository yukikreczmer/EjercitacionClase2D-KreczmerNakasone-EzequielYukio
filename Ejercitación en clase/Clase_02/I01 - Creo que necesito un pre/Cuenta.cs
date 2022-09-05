using System;

namespace I01___Creo_que_necesito_un_pre_
{
    public class Cuenta
    {
        public string titular;
        public float monto;

        public Cuenta(string titular, float monto = 0)
        {
            this.titular = titular;
            this.monto = monto;
        }

        public static string GetTitular(Cuenta cuenta)
        {
            return cuenta.titular;
        }

        public static float GetMonto(Cuenta cuenta)
        {
            return cuenta.monto;
        }

        public static void MostrarDatos(Cuenta cuenta)
        {
            string titularAux;
            float montoAux;
            titularAux = Cuenta.GetTitular(cuenta);
            montoAux = Cuenta.GetMonto(cuenta);
            Console.WriteLine($"Titular: {titularAux}");
            Console.WriteLine($"Monto: {montoAux}");
            // Console.WriteLine($"El valor máximo ingresado es: {maxNumeroIngresado}");
            //mostrar retornará una cadena de texto con todos los datos de la cuenta.
        }

        public static void IngresarDatos(Cuenta cuenta, float montoAAcreditar)
        {
            if(montoAAcreditar > 0)
            {
                cuenta.monto += montoAAcreditar;
            }
            //ingresar recibirá un monto para acreditar a la cuenta.Si el monto ingresado es negativo, no se hará nada.
        }

        public static void RetirarMonto(Cuenta cuenta, float montoARetirar)
        {
            if(montoARetirar > 0)
            {
                cuenta.monto -= montoARetirar;
            }
            //retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        }
    }

}