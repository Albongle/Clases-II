using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSingleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string mensaje = string.Empty;
        protected Singleton() 
        {
            this.mensaje = "Hola Mundo";
        }
        public static Singleton Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
