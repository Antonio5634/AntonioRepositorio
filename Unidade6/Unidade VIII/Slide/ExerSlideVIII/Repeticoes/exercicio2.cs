using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII.Repeticoes
{
    class exercicio2
    {
        static void Main5(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            do
            {
               
                j++;
                Console.WriteLine(j);

            }
            while (j == 100);
            Console.ReadKey();
        }
    }
}
