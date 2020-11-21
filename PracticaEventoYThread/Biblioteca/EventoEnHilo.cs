using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EventoEnHilo
    {
        public delegate void MostrarPersonas(Persona persona);
        public event MostrarPersonas EventoPersona;
        private int intervalo;
        Thread hilo;
        public EventoEnHilo()
        {
            hilo = new Thread(FuncionSinParametros);
        }


        public bool Activo
        {
            get
            {
                return this.hilo.IsAlive;
            }
            set
            {
                if (value && !object.ReferenceEquals(hilo, null) && !this.hilo.IsAlive)
                {
                    this.hilo.Start();
                }
                else if (!object.ReferenceEquals(hilo, null) && !value)
                {
                    this.hilo.Abort();
                }
            }

        }
        public int Intervalo { get { return this.intervalo; } set { this.intervalo = value; } }


        public void FuncionSinParametros()
        {
            while(true)
            {
                this.EventoPersona.Invoke(DevolverPersona());
                Thread.Sleep(this.Intervalo);
            }
           
        }

        public Persona DevolverPersona()
        {
            List<string> nombres = new List<string> {"Jose","Ramon","Alejandro","Ariel","Juan", "Helena","Mariela"};
            List<string> apellidos = new List<string> { "Perez", "Gonzalez", "Ramirez", "Lopez", "Fernandez", "Gutierrez", "Garcia" };
            Random random = new Random();
            Persona[] personas= new Persona[7];

            for (int i = 0; i < nombres.Count; i++)
            {
                personas[i] = new Persona(nombres[i], apellidos[i]);

            }
            return personas[random.Next(0,6)];

        }

    }
}
