﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Constructores
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string NombreEmpresa) : this()
        {
            this.razonSocial = NombreEmpresa;
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTodas
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine("La razon social es: *******" + this.razonSocial+ "*******");
            returnAux.AppendLine("La gananci total es: " + this.GananciasPorTodas);
            returnAux.AppendLine("La gananci Local es: " + this.GananciasPorLocal);
            returnAux.AppendLine("La gananci Provincial es: " + this.GananciasPorProvincial);
            returnAux.AppendLine("---------------------------------\n\n*******Listado de llamadas*******");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                returnAux.AppendLine(llamada.ToString());
            }
            return returnAux.ToString();
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganaciaLocal = 0;
            float gananciaProvincial = 0;
            foreach (Llamada llamada in this.Llamadas)
            {
                if(llamada is Local)
                {
                    ganaciaLocal += ((Local)llamada).CostoLlamada;
                }
                else if (llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }
            switch(tipo)
            {
                case Llamada.TipoLlamada.Local:
                    {
                        return ganaciaLocal;
                    }
                case Llamada.TipoLlamada.Provincial:
                    {
                        return gananciaProvincial;
                    }
                default:
                    {
                        return ganaciaLocal+gananciaProvincial;
                    }
            }
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdernarPorDuracion);
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool returnAux = false;
            foreach (Llamada l in c.listaDeLlamadas)
            {
                if(l==llamada)
                {
                    returnAux = true;
                }
            }
            return returnAux;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada llamandaNueva)
        {
            if(c!=llamandaNueva)
            {
                c.AgregarLlamada(llamandaNueva);
            }
            return c;
        }
        #endregion
    }
}
