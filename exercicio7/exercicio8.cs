using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    class exercicio8
    {
        public static int A, B, C, somaAB;
        static void Mai786(string[] args)
        {
            Console.WriteLine("informe um valor:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe um valor:");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe um valor:");
            C = Convert.ToInt32(Console.ReadLine());

            somaAB = A + B;

            if (somaAB < C)
            {
                Console.WriteLine("é menor");
            }
            else if (somaAB > C)
            {
                Console.WriteLine("é maior");
            }
            else if (somaAB == C)
            {
                Console.WriteLine("são iguais");
            }
            Console.ReadKey();
        }
    }
}
