using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII.Slide
{
    class exercicio7
    {
        static void Main67()
        {
            Random impar = new Random();
             int somaImpar = 0;
            for (int i = 0; i < 4; i++)
            {
                
                int numero = impar.Next(1, 7);
                if (numero % 2 == 1)
                {
                    somaImpar += numero;
                }
                Console.WriteLine(numero);
            }
            Console.WriteLine(" Valores Impares: " + somaImpar);
            if (somaImpar > 9)
            {
                Console.WriteLine("Venceu");
            }
            else
            {
                Console.WriteLine("Perdeu");
            }
            Console.ReadKey();

        }
    }
}
