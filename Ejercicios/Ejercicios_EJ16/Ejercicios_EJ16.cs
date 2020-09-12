using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ16
{
    class Ejercicios_EJ16
    {
        static void Main(string[] args)
        {
            byte notaUno;
            byte notaDos;
            Alumno[] alumno = new Alumno[3];
            for(int i=0; i<3;i++)
            {
                alumno[i] = new Alumno("Nombre-" + (i + 1), "Apellido-" + (i + 1), i + 1);
                Console.WriteLine("Ingrese la primer nota para el alumno {0}", i+1);
                byte.TryParse(Console.ReadLine(), out notaUno);
                Console.WriteLine("Ingrese la segunda nota para el alumno {0}", i+1);
                byte.TryParse(Console.ReadLine(), out notaDos);
                alumno[i].Estudiar(notaUno, notaDos);
            }

            foreach (Alumno alumnoAux in alumno)
            {
                Console.WriteLine(alumnoAux.Mostrar());
            }

            Console.ReadKey();
        }
    }
}
