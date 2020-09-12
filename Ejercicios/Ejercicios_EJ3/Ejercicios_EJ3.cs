using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EJ3
{
    class Ejercicios_EJ3
    {
        static void Main(string[] args)
        {
            int ingreso;
            bool flag;
            int cont;
            int acum;
            do
            {
                Console.WriteLine("Ingrese el numero mayor a 1: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso < 2)
                {
                    flag = true;
                    Console.WriteLine("ERROR. ¡Reingresar número mayor a 1!");
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Los numeros primos hasta el valor ingresado son:");
                    for (int i=2; i<=ingreso;i++)
                    {
                        cont = 1;
                        acum = 0;
                        do
                        {                           
                            if((i % cont)==0)
                            {
                                acum++;
                            }
                            cont++;
                        } while (acum < 3 && cont <= ingreso);
                        if(acum==2)
                        {
                            Console.WriteLine(i);
                        }
                    }                  
                }

            } while (flag);

            Console.ReadKey();
        }
    }
}
