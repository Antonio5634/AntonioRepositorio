using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_IX
{
    class Exercicio2
    {
        
        public static Random numero = new Random();
        static void Main4(string[] args)
        {
            int[] sequencia = new int[10];
            for (int i = 0; i < sequencia.Length; i++)
            {
                sequencia[i] += 1;
                Console.WriteLine(sequencia[i]);
                
            }


            Console.ReadKey();

        }

    }
}
