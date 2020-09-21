using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        public string MostrarDatos()
        {
            return "El auto numero: " + this.numero 
                + "\nEscuderia: " + this.escuderia 
                + "\nEn competencia: " + this.enCompetencia 
                + "\nCantidad de combustible: " + this.cantidadCombustible 
                + "\nVueltas restantes: " + this.vueltasRestantes;
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public short GetCombustible()
        {
            return this.cantidadCombustible;
        }
        public void SetCombustible(short cantidadCombustible)
        {
           this.cantidadCombustible=cantidadCombustible;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

    }
}
