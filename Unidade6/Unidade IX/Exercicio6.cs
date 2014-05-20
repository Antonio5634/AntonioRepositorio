using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_IX
{
    class Exercicio6
    {
        public static Random numero = new Random();
        static void Main5(string[] args)
        {
            int[] sequencia = new int[10];
            for (int i = 0; i < sequencia.Length; i++)
            {
                sequencia[i] = numero.Next(1, 1000);
                Console.WriteLine(sequencia[i]);

            }

            Console.ReadKey();
        }
   
    }
}
