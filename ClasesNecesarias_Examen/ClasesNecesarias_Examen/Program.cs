using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNecesarias_Examen
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        private delegate void Callback(object vehiculo);
        private void HabilitarIngresoVehiculo(object vehiculo)
        {
            if (true/*objeto.InvokeRequired*/)
            {
                Callback callback = new Callback(this.HabilitarIngresoVehiculo);
                object[] objs = new object[] { vehiculo };
                //this.Invoke(callback, objs);
            }
            else
            {
                //Accion a realizar
            }
        }

    }
}
