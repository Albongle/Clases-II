using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        protected Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public short Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
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
            }
        }
        protected virtual string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("Nombre: " + this.Nombre);
            returnAux.AppendLine("Edad: " + this.Edad);

            return returnAux.ToString();
        }
        public static explicit operator string(Persona persona)
        {
            return persona.Mostrar();
        }
        public abstract bool Validar();
    }
}
