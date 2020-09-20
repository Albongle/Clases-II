using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private long dni;
        private string nombre;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
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
        public string MostrarDatos()
        {
            return "DNI: " + this.Dni
                    + "\nNombre: " + this.Nombre;
        }
    }
}
