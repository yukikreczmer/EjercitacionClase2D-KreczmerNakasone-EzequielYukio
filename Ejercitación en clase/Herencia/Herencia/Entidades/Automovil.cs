using System;
using System.Text;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadPasajeros = cantidadPasajeros;
        }

        private short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        private int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }


        public string MostrarInfoAutomovil()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarInfo());
            sb.AppendLine($"Cantidad de Marchas: {CantidadMarchas}");
            sb.AppendLine($"Cantidad de Pasajeros: {CantidadPasajeros}");
            return sb.ToString();
        }
    }
}
