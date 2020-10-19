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
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("MiClase(int num1)", ex);
            }

        }


        public static void MiMetodoEstatico()
        {
            throw new DivideByZeroException("MetodoEstatico Division por cero");
        }
    }
}
