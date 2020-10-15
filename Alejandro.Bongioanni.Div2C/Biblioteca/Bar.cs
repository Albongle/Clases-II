using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        private Bar ()
        {
            empleados = new List<Empleado>();
            gente = new List<Gente>();
        }
        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }
        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }

        public static Bar GetBar()
        {
            if (singleton == null)
            {
                singleton = new Bar();
            }
            return singleton;
        }
        public static bool operator +(Bar b,Empleado empleado)
        {
            int flag = 0;
            bool returnAux = false;
            foreach (Empleado emp in b.empleados)
            {
                if (emp == empleado)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==0 && empleado.Validar())
            {
                b.empleados.Add(empleado);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator +(Bar b,Gente gente)
        {
            bool returnAux = false;
            if(b.gente.Count < (b.empleados.Count*10) && gente.Validar())
            {
                b.gente.Add(gente);
                returnAux = true;
            }
            return returnAux;
        }
        public override string ToString()
        {
            StringBuilder returAux = new StringBuilder();
            foreach (Empleado empleado in this.empleados)
            {
                returAux.AppendLine((string)empleado);
            }
            foreach (Gente gente in this.gente)
            {
                returAux.AppendLine((string)gente);
            }
            return returAux.ToString();
        }

    }
}
