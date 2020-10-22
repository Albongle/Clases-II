using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public static bool operator == (VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.Escuderia == v2.Escuderia) && (v1.Numero == v2.Numero);
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1==v2);
        }
        public virtual string MostrarDatos()
        {
            return "El Vehiculo numero: " + this.Numero
            + "\nEscuderia: " + this.Escuderia
            + "\nEn competencia: " + this.EnCompetencia
            + "\nCantidad de combustible: " + this.CantidadCombustible
            + "\nVueltas restantes: " + this.VueltasRestantes;
        }


    }
}
