using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico :Persona
    {
        private DateTime fechaNaciemiento;
        private DirectorTecnico(string nombre)
            :base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNaciemiento) :this(nombre)
        {
            this.fechaNaciemiento = fechaNaciemiento;
        }        
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.Nombre == dt2.Nombre && dt1.fechaNaciemiento == dt2.fechaNaciemiento);
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
        public string MostrarDatos()
        {
            StringBuilder returnAux = new StringBuilder();

            returnAux.AppendLine(base.MostrarDatos()
                + "\nNombre DT: " + this.Nombre
                + "\nFecha de Nacimiento: " + this.fechaNaciemiento);
            return returnAux.ToString();
          }
    }
}
