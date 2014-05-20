using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_IX
{
    class Exercicio7
    {
        public static Random numero = new Random();
        static void Main(string[] args)
        {
            int[] sequencia = new int[10];
            for (int i = 0; i < sequencia.Length; i++)
            {
                sequencia[i] = numero.Next(1, 10);
                Console.WriteLine(1*sequencia[i]);

            }

            Console.ReadKey();
        }
   
    }
}
