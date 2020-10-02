using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this(capacidadML, marca, Botella.Tipo.Vidrio, contenidoML)
        {

        }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        public override int ServirMedida()
        {
            int returnAux = base.Contenido;
            if (MEDIDA <= base.Contenido)
            {
                returnAux = (int)(MEDIDA * 0.8f);
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

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

    }
}
