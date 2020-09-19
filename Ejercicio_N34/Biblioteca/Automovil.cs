using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Automovil: VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public string MostrarDatos()
        {
            return "Cantidad de Puertas: " + this.cantidadPuertas
                + "\nCantitdad de Ruedas: " + this.cantidadRuedas
                + "\nColor: " + this.color
                + "\nCantidad de Marchas: " + this.cantidadMarchas
                + "\nCantidad de Pasajeros: " + this.cantidadPasajeros;
        }
        
    }
}
