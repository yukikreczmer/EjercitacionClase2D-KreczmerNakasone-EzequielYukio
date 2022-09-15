using System;
using System.Collections.Generic;
using Biblioteca;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Crear e instanciar el Dictionary<TKey,TValue> llamado maquinaExpendedora.
            2.Cargar por lo menos 10 elementos en formato clave-valor (clave=numero de posición, valor=nombre del producto)
            3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:
            •Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.
            •Pida al usuario elegir el número del producto que quiere
            •Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los productos SIN el producto 
            que ya eligió
            •El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.
            BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO 
            (que contenga nombre y precio del producto)*/


            char respuesta;
            int numeroIngresado;
            Producto producto = new Producto();
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();

            maquinaExpendedora.Add(0, "papitas");
            maquinaExpendedora.Add(1, "doritos");
            maquinaExpendedora.Add(2, "palitos");
            maquinaExpendedora.Add(3, "chisitos");
            maquinaExpendedora.Add(4, "coca");
            maquinaExpendedora.Add(5, "agua");
            maquinaExpendedora.Add(6, "sevenUp");
            maquinaExpendedora.Add(7, "pepsi");
            maquinaExpendedora.Add(8, "gomitas");
            maquinaExpendedora.Add(9, "galletitas");
            do
            {
                foreach (KeyValuePair<int, string> item in maquinaExpendedora)
                {
                    Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value}");
                }
                Console.WriteLine("Ingrese el numero del producto elegido: ");
                numeroIngresado = Inputs.PedirEnteroValido();
                if (maquinaExpendedora.TryGetValue(numeroIngresado, out producto))
                {
                    Console.WriteLine($"Recibiste: {producto}");
                    maquinaExpendedora.Remove(numeroIngresado);
                }
                else
                {
                    Console.WriteLine("No se encontro el producto");
                }



                Console.WriteLine("¿Desea salir? (S/N)");
                respuesta = Console.ReadKey().KeyChar;
            } while (!Validador.ValidarRespuesta(respuesta));



        }
    }
}
