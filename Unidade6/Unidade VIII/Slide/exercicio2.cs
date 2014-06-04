using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII.Slide
{
    class exercicio2
    {
        static void Main6()
        {
            Random divisao = new Random();

            int a = divisao.Next(20);
            int b = divisao.Next(20);

            Console.WriteLine("Valor de A:" + a);
            Console.WriteLine(" Valor de B"+ b);

            if (a % b == 0)
            {
                Console.WriteLine("É divisível");
            }
            else
            {
                Console.WriteLine("Não é divisível");
            }

        }
    }
}
