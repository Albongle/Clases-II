using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool returnAux = false;
            if(n!=c)
            {
                n.clientes.Enqueue(c);
                returnAux = true;
            }
            return returnAux;
        }
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                if (!(this.clientes.Contains(value)))
                {
                    this.clientes.Enqueue(value);
                }                
            }
        }
        public static bool operator == (Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente==c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
    }
}
