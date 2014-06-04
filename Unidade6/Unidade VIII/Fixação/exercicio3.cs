using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII
{
    class exercicio3
    {
        public static Random andar = new Random();
        static void Main4(string[] args)
        {

            for (int i = 0; i < 4; i++)
            {
                int bloco1 = andar.Next(11, 14);
                Console.WriteLine("Bloco 1:" + bloco1);
            }

            for (int j = 0; j < 4; j++)
            {
                int bloco2 = andar.Next(21, 24);
                Console.WriteLine("Bloco 2:" + bloco2);
            }
            for (int d = 0; d < 4; d++)
            {
                int bloco3 = andar.Next(31, 34);
                Console.WriteLine("Bloco 3:" + bloco3);
            }

            Console.ReadKey();

        }
    }
}
