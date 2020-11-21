using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio (Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            this.clientes = new List<string> { "Alejandro", "Ramon", "Juan", "Pedro", "Leo Messi", "Roberto" };
        }

        public Caja Caja1
        {
            get { return this.caja1; }
        }
        public Caja Caja2
        {
            get { return this.caja2; }
        }
        public List<string> Clientes
        {
            get { return this.clientes; }
        }

        public void AsignarCaja()
        {
            Console.WriteLine("--------------Asignando cajas---------------------");
            foreach (string cliente in this.clientes )
            {
                if(this.Caja1.FilaClientes.Count<this.Caja2.FilaClientes.Count)
                {
                    Console.WriteLine($"Cliente: {cliente} asignado a Caja 1");
                    this.Caja1.FilaClientes.Add(cliente);
                }
                else
                {
                    Console.WriteLine($"Cliente: {cliente} asignado a Caja 2");
                    this.Caja2.FilaClientes.Add(cliente);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
