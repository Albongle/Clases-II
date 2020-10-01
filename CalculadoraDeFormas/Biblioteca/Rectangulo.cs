using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo :Figura
    {
        protected double baseFigura;
        protected double alturaFigura;

        public Rectangulo(double baseFigura, double alturaFigura)
        {
            this.baseFigura = baseFigura;
            this.alturaFigura = alturaFigura;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (this.alturaFigura + this.baseFigura);
        }
        public override double CalcularSuperficie()
        {
            return this.baseFigura * this.alturaFigura;
        }
        public override string Dibujar()
        {
            return "Dibujando Rectangulo…";
        }
    }
}
