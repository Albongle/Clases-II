using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ5
{
    class Ejercicios_Ej5
    {
        static void Main(string[] args)
        {
            int ingreso;
            bool flag;
            int primerAcumulador = 0;
            int segundoAcumulador = 0;
            int i = 0;
            int cont = 0;
            int numeroPerfecto=int.MinValue;
            do
            {
                Console.WriteLine("Ingrese el numero mayor a 1: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso < 1)
                {
                    flag = true;
                    Console.WriteLine("ERROR. ¡Reingresar número mayor a 1!");
                }
                else
                {
                    flag = false;
                    do
                    {
                        i++;
                        primerAcumulador += i;
                        for (int j = i+2; j < ingreso; j++)
                        {
                            segundoAcumulador += j;
                            if(segundoAcumulador==primerAcumulador)
                            {
                                if(numeroPerfecto!=(i+1))
                                {
                                    i++;
                                    numeroPerfecto = i;
                                    cont++;
                                    Console.WriteLine("El {0} centro numerico es {1}", cont, numeroPerfecto);
                                    segundoAcumulador = 0;
                                    primerAcumulador += i;
                                    break;
                                }
                            }
                            else if (segundoAcumulador>primerAcumulador)
                            {
                                segundoAcumulador = 0;
                                break;
                            }
                        }                       
                    } while (i < ingreso);
                }
            } while (flag);

            Console.ReadKey();
        }
    }
}
