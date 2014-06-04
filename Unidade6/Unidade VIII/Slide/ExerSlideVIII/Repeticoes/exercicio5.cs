using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII.Repeticoes
{
    class exercicio5
    {
        static void Main67(string[] args)
        {
            int i = 10;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            } while (i <= 100);
            Console.ReadKey();
        }
    }
}
