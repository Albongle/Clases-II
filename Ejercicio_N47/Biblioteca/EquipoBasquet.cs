using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoBasquet:Equipo
    {
        public EquipoBasquet(string nombre, DateTime fechaCreacion) 
            : base(nombre, fechaCreacion)
        {
        }

        public override string Ficha()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine($"{base.Nombre}, fundado el {base.FechaDeCreacion.ToString("dd-MM-yyyy")}");
            return returnAux.ToString();
        }
    }
}
