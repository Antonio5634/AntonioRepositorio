using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.UnidadeVII
{
    class exercicio1
    {
        static void Main5457()
        {
            int[] codigo = new int[2];
            double[] preco = new double[15];
            double maior_Preco = 0, soma_Preco = 0, media = 0;


            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe o codigo: ");
                codigo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o preco do produto: ");
                preco[i] = int.Parse(Console.ReadLine());

                soma_Preco += preco[i];
                if (maior_Preco < preco[i])
                {
                    maior_Preco = preco[i];
                }
            }

            media = soma_Preco / 15;

            Console.WriteLine("O maior valor: " + maior_Preco);
            Console.WriteLine("A media dos valores:" + media);


            Console.ReadKey();

        }
    }
}
