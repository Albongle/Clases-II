using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado: Persona
    {
        private int dni;
        public Empleado(string nombre, short edad)
            :this(nombre, edad,-1)
        {
            
        }
        public Empleado (string nombre, short edad, int dni)
            :base(nombre,edad)
        {
            this.dni = dni;
        }
        public override bool Validar()
        {
            bool returAux = false;
            if(base.Edad>21 && base.Nombre.Length>2)
            {
                returAux = true;
            }
            return returAux;
        }
        public static bool operator == (Empleado e1, Empleado e2)
        {
            string aux;
            return (e1.Edad == e1.Edad) && (e1.Nombre == e2.Nombre);
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
        protected override string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            if(this.dni!=-1)
            {
                returnAux.AppendLine("Empleado");
                returnAux.AppendLine(base.Mostrar());
                returnAux.AppendLine("DNI: " + this.dni);
            }
            return returnAux.ToString();            
        }
    }
}
