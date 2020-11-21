using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    
    public class Temporizador
    {
        public delegate void encargadoTiempo(); // delegado al metodo, que devuelve lo del metodo
        private Thread hilo;
        private int intervalo;
        public event encargadoTiempo EventoTiempo; // es un evento del tipo del delegado, porque el delgado es el que le va a decir que metodos son capaces de manejarlo
        public Temporizador()
        {
            hilo = new Thread(Corriendo);
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
                else if(!object.ReferenceEquals(hilo, null) && !value)
                {
                    this.hilo.Abort();
                }
            }

        }
        public int Intervalo { get { return this.intervalo; } set { this.intervalo = value; } }
        private void Corriendo()// donde se va a provocar el evento
        {
            while (true)
            {
                if (!object.ReferenceEquals(this.EventoTiempo, null))
                {
                    this.EventoTiempo.Invoke();
                    Thread.Sleep(this.Intervalo);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
