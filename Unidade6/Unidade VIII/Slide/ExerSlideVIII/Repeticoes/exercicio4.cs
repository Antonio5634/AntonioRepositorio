using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII.Repeticoes
{
    class exercicio4
    {
        static void Main432(string[] args)
        {
            int i = 1;
            do
            {
                if (i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;


            } while (i <= 100);
            Console.ReadKey();
        }
    }
}
