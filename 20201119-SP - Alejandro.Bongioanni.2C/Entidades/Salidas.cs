using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Salidas
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;
        public Salidas()
        {
            this.FechaInicio = DateTime.Now;
        }

        public DateTime FechaFin {
            get
            {
                return this.fechaFin;
            }  
            set
            {
                this.fechaFin = value; 
            } 
        }
        public DateTime FechaInicio
        {
            get
            {
                return this.fechaInicio;
            }
            set
            {
                this.fechaInicio = value;
            }
        }
        public int TiempoTotal
        {
            get
            {
                return (this.FechaInicio-this.FechaFin).Minutes;
            }
    
        }

        public void FinalizarSalida()
        {
            this.FechaFin = DateTime.Now;
        }
    }
}
