using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_coleções
{
    class exercicio3
    {
        public static Random haha = new Random();
        static void Main()
        {
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                if (lista1[i] == 0)
                {
                    lista2[i] = 1;
                }
                else
                    lista2[i] = lista1[i];

                Console.WriteLine(" vetor 2: " + lista2[i]);
            }
        }
    }
}
