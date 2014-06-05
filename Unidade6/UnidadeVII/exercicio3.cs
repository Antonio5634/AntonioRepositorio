using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.UnidadeVII
{
    class exercicio3
    {
        static void Main()
        {
            Console.WriteLine("Informe o numero total de mercadorias em estoque: ");
            int numTotal = Convert.ToInt32(Console.ReadLine());

            double[] valor = new double[numTotal];

            double TotalEstoque = 0, media = 0;

            for (int a = 0; a < numTotal; a++)
            {
                Console.WriteLine("Informe o valor da mercadoria: ");
                valor[a] = Convert.ToDouble(Console.ReadLine());

                TotalEstoque += valor[a];

            }

            media = TotalEstoque / numTotal;

            Console.WriteLine("O valor total em estoque: " + TotalEstoque);
            Console.WriteLine("A media dos valores em estoque: " + media);

            Console.ReadKey();

        }
    }
}
