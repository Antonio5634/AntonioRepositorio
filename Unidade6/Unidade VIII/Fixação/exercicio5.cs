using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII
{
    class exercicio5
    {
        public static double soma;
        static void Main67()
        {
            Random dado1 = new Random();
            int[] dado = new int[10];

            for (int i = 0; i < 10; i++)
            {
                dado[i] = dado1.Next(2, 7);
                soma += dado[i];
            }
            for (int i = 0; i < 10; i++)
            {
                if (dado[i] == 6 && dado[i] == 6)
                {
                    Console.WriteLine("Você Perdeu");
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valores: " + dado[i]);
            }
            Console.WriteLine("Soma valores: " + soma);
            if (soma % 2 == 1)
            {
                Console.WriteLine("Você e o Vencedor");
            }
            Console.ReadKey();

        }
    }
}
