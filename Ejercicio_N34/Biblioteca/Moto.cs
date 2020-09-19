using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto :VehiculoTerrestre
    {
        public short cilindrada;
        public Moto(short cilindrada, Colores color,short cantidadRuedas, short cantidadPuertas)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
        public string MostrarDatos()
        {
            return "Cantidad de Puertas: " + this.cantidadPuertas
                + "\nCantitdad de Ruedas: " + this.cantidadRuedas
                + "\nColor: " + this.color
                + "\nCilindrada: " + this.cilindrada;
        }
    }
}
