using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;
        protected Sobreescrito ()
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad { get;}
        public abstract string MiMetodo();
    }
}
