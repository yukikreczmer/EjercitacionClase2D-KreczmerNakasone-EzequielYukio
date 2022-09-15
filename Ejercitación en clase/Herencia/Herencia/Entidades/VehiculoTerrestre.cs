using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        protected short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        protected short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        protected Colores Color { get => color; set => color = value; }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.Color = color;
        }

        protected string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Ruedas: {CantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {CantidadPuertas}");
            sb.AppendLine($"Color: {Color}");
            return sb.ToString();
        }
    }
}
