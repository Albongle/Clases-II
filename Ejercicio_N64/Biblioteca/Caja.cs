using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Caja
    {
        private List<string> filaClientes;
        public Caja ()
        {
            filaClientes = new List<string>();
        }
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }
        public void AtenderClientes()
        {
            foreach (string cliente in this.filaClientes)
            {
                Console.WriteLine($"Cliente {cliente}, atendido en {Thread.CurrentThread.Name}");
                Thread.Sleep(2000);
            }
        }


    }
}
