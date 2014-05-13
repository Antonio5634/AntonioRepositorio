using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII
{
    class exercicio2
    {
        public static Random valor = new Random();
        public static double preco;
        static void Main34(string[] args)
        {
            double preco = valor.NextDouble() * 10;
            Console.WriteLine(preco);
            if (preco >= 0.5)
            {
                Console.WriteLine("é caro");
            }
            else
            {
                Console.WriteLine("é super barato");

            }
            Console.ReadKey();

        }
    }
}
