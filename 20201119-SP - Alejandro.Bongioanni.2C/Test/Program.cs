using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Bombero bombero = new Bombero("Jose");
            Bombero bombero1;

            bombero.Guardar(bombero);
            bombero1 = bombero.Leer();

            Console.ReadKey();
        }
    }
}
