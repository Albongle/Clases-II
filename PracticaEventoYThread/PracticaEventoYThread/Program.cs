using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace PracticaEventoYThread
{
    class Program
    {
        static void Main(string[] args)
        {
            EventoEnHilo eventoEnHilo = new EventoEnHilo();
            eventoEnHilo.EventoPersona += EventoEnHilo_EventoPersona;
            eventoEnHilo.Intervalo = 10000;
            eventoEnHilo.Activo = true;


            Console.ReadKey();
        }

        private static void EventoEnHilo_EventoPersona(Persona persona)
        {
            Console.WriteLine(persona.ToString());
        }
    }
}
