using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII
{
    class exercicio4
    {
        public static Random tabuada = new Random();
        static void Main343(string[] args)
        {
            for (int a = 1; a < 10; a++)
            {
                int tabuada1 = tabuada.Next(1, 10);
                int tabuada2 = tabuada.Next(1, 10);
                Console.WriteLine(" ", +tabuada1, " ", +tabuada2);
            }
            Console.ReadKey();
        }
    }
}
