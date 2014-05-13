using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII
{
    class exercicio1
    {
        public static Random notas = new Random();
        public static double n1;
        static void Main2(string[] args)
        {
            double n1 = notas.Next(0, 10);
            Console.Write(n1);
            if (n1 >= 7)
            {
                Console.WriteLine("aprovado");
            }
            else
               
                {
                    Console.WriteLine("reprovado");
                }
            Console.ReadKey();
        }
    }
}
