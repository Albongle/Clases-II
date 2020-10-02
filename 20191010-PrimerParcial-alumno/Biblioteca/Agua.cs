using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;
        public Agua(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {

        }
        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            int returnAux = base.Contenido;
            if (medida <= base.Contenido)
            {
                returnAux = medida;
            }
            base.contenidoML -= returnAux;
            return returnAux;
        }
        protected override string GenerarInforme()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.Append(base.GenerarInforme());
            return returnAux.ToString();
        }

    }
}
