using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    public class Libros
    {
        List<string> paginas = new List<string>();

        public string this[int i]
        {
            get 
            {
                string returnAux = string.Empty;
                if(i>=0 && i < paginas.Count)
                {
                    returnAux = this.paginas[i];
                }
                return returnAux;
            }
            set 
            {
                if(i>=this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if (i>=0 && i <this.paginas.Count)
                {
                    this.paginas[i] = value;
                }

            }       
        }
    }
}
