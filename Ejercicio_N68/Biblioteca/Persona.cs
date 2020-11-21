using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   
    public class Persona
    {
        private string apellido;
        private string nombre;
        public delegate void DelegadoString(string objetc);
        public event DelegadoString EventoString;

        public Persona()
        {
            this.apellido=string.Empty;
            this.nombre = string.Empty;
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
                this.EventoString(this.apellido);
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
                this.EventoString(this.nombre);
            }
        }

        public string Mostrar()
        {
            return $"{this.Nombre}, {this.Apellido}";
        }
    }
}
