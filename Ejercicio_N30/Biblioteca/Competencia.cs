using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this ()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random combusRandom = new Random();
            bool returnAux = false;
            if (c.competidores.Count() < c.cantidadCompetidores && (c != a))
            {
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCombustible((short)combusRandom.Next(15, 100));
                c.competidores.Add(a);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool returnAux = false;
            if (c.competidores.Count() > 0 && (c == a))
            {
                c.competidores.Remove(a);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}

