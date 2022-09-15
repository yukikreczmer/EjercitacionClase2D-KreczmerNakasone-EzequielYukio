using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        private int cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, int cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.Cilindrada = cilindrada;
        }

        private int Cilindrada { get => cilindrada; set => cilindrada = value; }

        public string MostrarInfoMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarInfo());
            sb.AppendLine($"Cilindrada: {Cilindrada}");
            return sb.ToString();
        }
        StringBuilder sb = new StringBuilder();
    }
}
