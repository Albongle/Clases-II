using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre)
            :base(dni,nombre)
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public float PromedioDeGoles
        {
            get
            {
                if (this.partidosJugados > 0)
                {
                    return this.TotalGoles / (float)this.PartidosJugados;
                }
                else
                {
                    return 0;
                }
            }
        }
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public string MostrarDatos()
        {
            return "Jugador: " + this.Nombre
                + "\nDNI: " + this.Dni
                + "\nPartidos Jugados: " + this.partidosJugados 
                + "\nTotal Goles: " + this.totalGoles 
                + "\nPromedio Goles: " + this.PromedioDeGoles;
        }

    }
}
