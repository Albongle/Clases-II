using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;
        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento (string nombre, int espacioDisponible)
            :this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("Estacionamiento: " + e.nombre);
            returnAux.AppendLine("Espacio Disponible: " + e.espacioDisponible);
            returnAux.AppendLine("Ocupado: " + e.vehiculos.Count);
            foreach (Vehiculo vehiculo in e.vehiculos)
            {
                returnAux.AppendLine(vehiculo.ConsultarDatos());

            }
            return returnAux.ToString();
        }
        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if(e!=v && !string.IsNullOrEmpty(v.Patente) &&  e.vehiculos.Count< e.espacioDisponible)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }
        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            string returnAux = "El vehículo no es parte del estacionamiento";
            if(e==v)
            {
                e.vehiculos.Remove(v);
                returnAux = v.ImprimirTicket();
            }
            return returnAux;
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returAux = false;
            foreach (Vehiculo v in estacionamiento.vehiculos)
            {
                if(v==vehiculo)
                {
                    returAux = true;
                    break;
                }
            }
            return returAux;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
                return !(estacionamiento == vehiculo);
        }

    }
}
