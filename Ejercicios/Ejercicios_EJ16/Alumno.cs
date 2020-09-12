using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private Random random = new Random();
        public string apellido;
        public int legajo;
        public string nombre;
        
        private void SetNotaUno(byte auxNota)
        {
            this.nota1 = auxNota;
        }
        private void SetNotaDos(byte auxNota)
        {
            this.nota2 = auxNota;
        }
        public Alumno (string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        private void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next();
            }
            else
            {
                this.notaFinal = -1;
            }
            
        }
        public void Estudiar(byte notaUno,byte notaDos)
        {
            SetNotaUno(notaUno);
            SetNotaDos(notaDos);
        }
        public string Mostrar()
        {
            string returAux;
            string resultado="";
            this.CalcularFinal();
            if (this.notaFinal==-1)
            {
                resultado = "Alumno desaprobado";
            }
            else
            {
                resultado = this.notaFinal.ToString();
            }
            
            returAux = "El alumno " + this.nombre + " " + this.apellido + " Con legajo " + this.legajo + " Su nota final es "+ resultado; 
            return returAux;
        }
    }
}
