using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII.Slide
{
    class exercicio6
    {
        
        static void Main67()
        {
            int soma = 0;
            Random dado = new Random();

            for (int i = 0; i < 5; i++)
            {
                int numero = dado.Next(1, 7);
                soma += numero;
                Console.WriteLine("Numero: " + numero);
            }
            Console.WriteLine("Soma: " + soma);
            if (soma > 19)
            {
                Console.WriteLine("O jogador venceu");
            }
            else
            {
                Console.WriteLine("Perdeu");
            }
            Console.ReadKey();

        }
    }
}
