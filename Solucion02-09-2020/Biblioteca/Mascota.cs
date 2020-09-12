using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private DateTime fechaNacimiento;
        private string nombre;
        private string especie;
        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
            this.especie = especie;
        }
        public string MostrarDatos()
        {
            return "Nombre : " + this.nombre + " Fecha de nacimiento :" + this.fechaNacimiento.ToString("dd/MM/yyyy") + " Edad: " +EdadMascota() + " Tipo " + this.especie;
        }
        private int EdadMascota()
        {
            int returnAux;
            DateTime fechaActual=DateTime.Today;
            returnAux=fechaActual.Year- this.fechaNacimiento.Year;
            return returnAux;
        }
    }
}
