using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII
{
    class exercicio5
    {
        public static Random num = new Random();

        static void Main688(string[] args)
        {
            int a = num.Next(0, 10);
            int b = num.Next(0, 10);
            if (a % b == 0)
            {
                Console.WriteLine("" + a);
                Console.WriteLine("" + b);
                Console.WriteLine("é divisivel");
            }
            else
            {
                Console.WriteLine("" + a);
                Console.WriteLine("" + b);
                Console.WriteLine("nao é divisivel");
            }
            Console.ReadKey();
        }
    }
}
