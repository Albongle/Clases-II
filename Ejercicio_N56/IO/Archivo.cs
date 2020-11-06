using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool returnAux=false;
            if(validaExistencia)
            {
                if(File.Exists(ruta))
                {
                    returnAux = true;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            return returnAux;
        }
    }
}
