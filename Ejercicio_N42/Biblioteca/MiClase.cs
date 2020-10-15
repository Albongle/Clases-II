using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MiMetodoEstatico();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }

        }
        public MiClase(int num1)
        {
            try
            {
                MiClase.MiMetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("2 constructor", ex);
            }

        }


        public static void MiMetodoEstatico()
        {
            throw new DivideByZeroException("Division por cero");
        }
    }
}
