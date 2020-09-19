using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoTerrestre
    {
        public enum Colores { Rojo, Blanco, Azul, Gris, Negro };
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;    

        protected VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

    }
}
