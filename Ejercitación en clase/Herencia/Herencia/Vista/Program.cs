using Entidades;
using System;
using System.Collections.Generic;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VehiculoTerrestre> listaVehiculos = new List<VehiculoTerrestre>();

            Automovil automovil1 = new Automovil(4, 5, Colores.Rojo, 5, 5);
            Automovil automovil2 = new Automovil(4, 3, Colores.Azul, 6, 2);
            Moto moto1 = new Moto(2, 0, Colores.Blanco, 125);
            Camion camion1 = new Camion(6, 2, Colores.Gris, 5, 1500);

            listaVehiculos.Add((Automovil)automovil1);
            listaVehiculos.Add(automovil2);
            listaVehiculos.Add(moto1);
            listaVehiculos.Add(camion1);

            foreach(VehiculoTerrestre item in listaVehiculos)
            {
                /*if (item is Automovil)
                {
                    Console.WriteLine("Automovil:");
                    Console.WriteLine(((Automovil)item).MostrarInfoAutomovil()); 
                }
                if(item is Moto)
                {
                    Console.WriteLine("Moto:");
                    Console.WriteLine(((Moto)item).MostrarInfoMoto());
                }
                if( item is Camion)
                {
                    Console.WriteLine("Camion:");
                    Console.WriteLine(((Camion)item).MosrtarInfoCamion());
                }*/
                
                switch (item)
                {
                    case Automovil:
                        Console.WriteLine("Automovil:");
                        Console.WriteLine(((Automovil)item).MostrarInfoAutomovil());
                        break;
                    case Moto:
                        Console.WriteLine("Moto:");
                        Console.WriteLine(((Moto)item).MostrarInfoMoto());
                        break;
                    case Camion:
                        Console.WriteLine("Camion:");
                        Console.WriteLine(((Camion)item).MosrtarInfoCamion());
                        break;
                }
                
            }
        }
    }
}
