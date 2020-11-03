using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Catuchera1
    {
        private List<IAcciones> acciones;
        public Catuchera1()
        {
            this.acciones = new List<IAcciones>();
        }

        public List<IAcciones> Acciones { get { return this.acciones; } }

        public bool ProbarElementos()
        {
            int qBoligrafos = 0;
            int cont = 0;
            foreach (IAcciones accion in this.Acciones)
            {
                if(accion is Boligrafo)
                {
                    if (accion.UnidadDeEscritura < 1)
                    {
                        accion.Recargar(20);
                    }
                    else
                    {
                        accion.UnidadDeEscritura -= 1;
                        cont++;
                    }
                    qBoligrafos++;
                }              
            }
            if(cont==qBoligrafos)
            {
                return true;
            }
            return false;
        }
    }
}
