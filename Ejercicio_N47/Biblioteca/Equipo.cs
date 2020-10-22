﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public DateTime FechaDeCreacion { get { return this.fechaCreacion; } set { this.fechaCreacion = value; } }

        public static bool operator == (Equipo e1, Equipo e2)
        {
            return (e1.fechaCreacion==e2.fechaCreacion) && (e1.nombre==e2.nombre);
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public abstract string Ficha();

    }
}
