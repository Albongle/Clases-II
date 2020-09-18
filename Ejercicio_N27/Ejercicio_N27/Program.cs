using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Stack<int> listaPila = new Stack<int>();
            Queue<int> listaQueue = new Queue<int>();
            List<int> listaLista = new List<int>();
            List<int> listaAux = new List<int>();


            for (int i = 0; i < 20; i++)
            {
                listaPila.Push(azar.Next(-100, 100));
                listaQueue.Enqueue(azar.Next(-100, 100));
                listaLista.Add(azar.Next(-100, 100));
            }

            listaAux = listaPila.ToList();
            listaAux.Sort(FuncionCriterio);
            Console.WriteLine("Muestro Lista Original de Pila\n\n");
            Imprime(listaPila);
            Console.WriteLine("Muestro Lista de Pila positivos\n\n");
            Imprime(listaAux, -1);
            Console.WriteLine("Muestro Lista de Pila negativos\n\n");
            Imprime(listaAux, 1);

            listaAux.Clear();// borro la lista Aux
            listaAux = listaQueue.ToList(); // convierto la lista de colas en List
            listaAux.Sort(FuncionCriterio);
            Console.WriteLine("Muestro Lista Original de Queue\n\n");
            Imprime(listaQueue);
            Console.WriteLine("Muestro Lista de Queue positivos\n\n");
            Imprime(listaAux, -1);
            Console.WriteLine("Muestro Lista de Queue negativos\n\n");
            Imprime(listaAux, 1);

            Console.WriteLine("Muestro Lista Original de Lista\n\n");
            Imprime(listaLista);
            listaLista.Sort(FuncionCriterio);
            Console.WriteLine("Muestro Lista de Lista positivos\n\n");
            Imprime(listaLista, -1);
            Console.WriteLine("Muestro Lista de Lista negativos\n\n");
            Imprime(listaLista, 1);

            Console.ReadKey();
        }

        private static int FuncionCriterio(int numeroUno, int numeroDos)
        {
            int returnAux = 0;
            if (numeroUno > numeroDos)
            {
                returnAux = -1;
            }
            else if (numeroUno < numeroDos)
            {
                returnAux = 1;
            }
            return returnAux;
        }
        private static void Imprime(List<int> listaRecibida)
        {
            for (int i = 0; i < listaRecibida.Count; i++)
            {
                Console.WriteLine(listaRecibida[i]);
            }
        }
        private static void Imprime(Queue<int> QueueRecibida)
        {
            while(QueueRecibida.Count>0)
            {
                Console.WriteLine(QueueRecibida.Dequeue());
            }
        }
        private static void Imprime(Stack<int> PilaRecibida)
        {
            while(PilaRecibida.Count>0)
            {
                Console.WriteLine(PilaRecibida.Pop());
            }     
        }
        private static void Imprime(List<int> listaRecibida,int criterio)
        {
            switch (criterio)
            {
                case -1:
                    {
                        for (int i = 0; i < listaRecibida.Count; i++)
                        {
                            if (listaRecibida[i] > 0)
                            {
                                Console.WriteLine(listaRecibida[i]);
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        for (int i = (listaRecibida.Count-1); i >=0; i--)
                        {
                            if (listaRecibida[i] < 0)
                            {
                                Console.WriteLine(listaRecibida[i]);
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Debe pasar un criterio");
                        break;
                    }
            }
        }
    }
}
