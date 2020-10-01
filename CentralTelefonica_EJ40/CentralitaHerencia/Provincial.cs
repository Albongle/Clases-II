using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial :Llamada
    {
        #region Atributos
        public enum Franja {Franja_1,Franja_2,Franja_3};
        protected Franja franjaHoraria;
        #endregion

        #region Constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion,destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja mifranja, Llamada llamada)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = mifranja;
        }
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine(base.Mostrar());
            returnAux.AppendLine("La franja Horaria es: " + this.franjaHoraria);
            returnAux.AppendLine("El costo de la llamada provincial es: " + this.CostoLlamada);
            return returnAux.ToString();
        }
        private float CalcularCosto()
        {
            float returnAux = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        returnAux = this.duracion * (float)0.99;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        returnAux = this.duracion * (float)1.25;
                        break;
                    }
                case Franja.Franja_3:
                    {
                        returnAux = this.duracion * (float)0.66;
                        break;
                    }
            }
            return returnAux;
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
