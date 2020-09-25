using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SobreSobreescrito :Sobreescrito
    {
        public SobreSobreescrito()
        { 
        }
        public override string MiPropiedad 
        {
            get
            {
                return base.miAtributo;
            }
        }
        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
    }
}
