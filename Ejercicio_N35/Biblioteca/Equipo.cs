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
            int flag = 0;
            if (e.jugadores.Count() < e.cantidadDeJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if(jugador==j)
                    {
                        flag = 1;
                    }
                }
                if(flag==0)
                {
                    e.jugadores.Add(j);
                    returnAux = true;
                }
            }
            return returnAux;
        }
    }
}
