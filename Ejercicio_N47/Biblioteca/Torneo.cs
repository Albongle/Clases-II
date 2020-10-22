using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Torneo <T> where T:Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        private string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine($"Torneo: {this.nombre}\n");
            returnAux.AppendLine("Listado de equipos del torneo:");
            foreach (T equipo in this.equipos)
            {
                returnAux.Append($"{equipo.Ficha()}");
            }
            return returnAux.ToString();
        }

        public string JugarPartido 
        { 
            get 
            {
                Random random = new Random();
                return CalcularPartido(this.equipos[random.Next(0, this.equipos.Count)], this.equipos[random.Next(0, this.equipos.Count)]); 
            } 
        }
        
        private string CalcularPartido(T e1, T e2)
        {
            Random random = new Random();
            return $"{e1.Nombre}: {random.Next(0, 10)} - {e2.Nombre}: {random.Next(0, 10)}";
        }

        public static bool operator ==(Torneo<T> t, T e )
        {
            foreach (Equipo equipo in t.equipos)
            {
                if(equipo== e)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }
        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if(t!=e)
            {
                t.equipos.Add(e);
                return t;
            }
            else
            {
                return t;
            }
        }
        /// <summary>
        /// Devuelve la informacion correspondiente al torneo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
