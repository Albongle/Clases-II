using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        private float tinta;
        private ConsoleColor color;
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.color = color;
        }
        public ConsoleColor Color { get { return this.color; } set { this.color = value; } }
        public float UnidadDeEscritura { get { return this.tinta; } set { this.tinta = value; }  }

        public EscrituraWrapper Escribir(string texto)
        {
            this.tinta -= (float)texto.Length * 0.3F;
            return new EscrituraWrapper(texto, ConsoleColor.Gray);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadDeEscritura+= unidades;
            return true;
        }
        public override string ToString()
        {
            return $"Boligrafo con color de escritura {this.Color} y su nivel es {this.UnidadDeEscritura}";
        }
    }
}
