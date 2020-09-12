using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicios_EJ12
{
    class Ejercicios_EJ12
    {
        static void Main(string[] args)
        {
            int ingreso;         
            int i = 0;
            int acum = 0;
            bool validacion;
            char pregunta;
            bool respuesta=true;
            do
            {
                Console.WriteLine("Ingrese el numero {0}:", i);
                int.TryParse(Console.ReadLine(), out ingreso);
                if ((validacion = ValidarNumero.ValidarInt(ingreso, 0, 10000)))
                {
                    acum += ingreso;
                    Console.WriteLine("Desea seguir ingresando numeros (s/n)?");
                    pregunta = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    respuesta=ValidarRespuesta.ValidaS_N(pregunta);
                    i++;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número >= a 0y <= que 10000");
                }
            } while (validacion == true && respuesta==true);
            Console.WriteLine("El resultado de la suma es {0}", acum);
            Console.ReadKey();

        }
    }

}
