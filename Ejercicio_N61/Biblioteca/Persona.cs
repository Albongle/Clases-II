using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public Persona(int id, string nombre, string apellido)
            :this(nombre, apellido)
        {
            this.Id = id;
        }

        public int Id { get { return this.id; }  set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public override string ToString()
        {
            return $"{this.Id} - {this.Nombre}, {this.Apellido}"; 
        }
    }
}
