using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII
{
    class exercicio1
    {
        public static Random alea = new Random();
        static void Main3434(string[] args)
        {
            int primeiro = alea.Next(1, 1000);
            int segundo = alea.Next(1, 1000);
            Console.WriteLine(primeiro);
            Console.WriteLine(segundo);
            if (primeiro == segundo)
            {
                Console.WriteLine("primeiro<segundo");
            }
            else
            {
                Console.WriteLine("segundo<primeiro");
            }
            Console.ReadKey();
        }
    }
}
