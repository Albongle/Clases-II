using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        
        public Boligrafo(ConsoleColor colorAux, short tintaAux)
        {
            this.color = colorAux;
            this.tinta = tintaAux;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta (short tintaAux)
        {
            if(tintaAux>0 && this.tinta<cantidadTintaMaxima)
            {
                CargaTinta(tintaAux);
            }
            else if(tintaAux <0 && this.tinta>0)
            {
                GastaTinta(tintaAux);
            }
        }
        private void CargaTinta (short tintaAux)
        {
            short cont = 0;
            while(this.tinta<=cantidadTintaMaxima && tintaAux!= cont)
            {
                this.tinta++;
                cont++;
            }
        }
        private void GastaTinta(short tintaAux)
        {
            short cont = 0;
            while (this.tinta >=0 && tintaAux != cont)
            {
                this.tinta--;
                cont--;
            }
        }
        public void Recargar()
        {
            CargaTinta(100);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            string stringAux = "";
            bool returAux = false;
            short cont = 0;

            if(this.tinta==0)
            {
                dibujo = "No se puede pintar, ya que no se posee tinta";
            }
            else
            {
                while(gasto>0 && (this.tinta-cont>0))
                {
                    stringAux += "*";
                    cont++;
                    gasto--;
                }
                dibujo = stringAux;
                returAux = true;
                cont *= -1;
                SetTinta(cont);
            }
            return returAux;
        }
    }
  
}
