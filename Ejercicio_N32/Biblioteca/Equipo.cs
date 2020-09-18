using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short canitdadJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = canitdadJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool returnAux = false;
            if (e.jugadores.Count() < e.cantidadDeJugadores && !(e.jugadores.Contains(j)))
            {
                e.jugadores.Add(j);
                returnAux = true;
            }
            return returnAux;
        }
    }
}
