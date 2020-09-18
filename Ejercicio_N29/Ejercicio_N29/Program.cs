using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador[] jugadores = new Jugador[10];
            Equipo afaJuniors = new Equipo(6, "AFA Juniors");

            for (int i = 0; i < jugadores.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre, goles y partidos para el jugador [{0}]", i);
                jugadores[i] = new Jugador(i, Console.ReadLine(),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
                if ((afaJuniors+jugadores[i]))
                {
                    Console.WriteLine("Se Agrego el siguiente Jugador al equipo {0}", jugadores[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se agrego ya que el equipo esta completo esta completa: {0}", jugadores[i].MostrarDatos());
                }

            }
        }
    }
}
