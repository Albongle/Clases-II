using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gente : Persona
    {
        public Gente(short edad)
            : this(string.Empty, edad)
        {

        }
        public Gente(string nombre, short edad)
            : base(nombre, edad)
        {

        }
        public override bool Validar()
        {
            bool returnAux = false;
            if (base.Edad > 18)
            {
                returnAux = true;
            }
            return returnAux;
        }
        protected override string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("Gente");
            returnAux.AppendLine(base.Mostrar());
            return returnAux.ToString();
        }
    }
}
