using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.UnidadeVII
{
    class exercicio9
    {
        public static double quantidade_adquirida, preco_unitario,total,desconto;
        public static string nome_produto;

        static void Main54(string[] args)
        {
            Console.WriteLine("informeo nomedo produto:");
            nome_produto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("informe a quantidade que do produto:");
            quantidade_adquirida = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe o valor do produto:");
            preco_unitario = Convert.ToDouble(Console.ReadLine());
            total = quantidade_adquirida * preco_unitario;
            if (quantidade_adquirida <= 5)
            {
                desconto = total * 0.02;
            }
            else
                if (quantidade_adquirida > 5 && quantidade_adquirida <= 10)
                {
                    desconto = total * 0.03;
                }
                else
                    if (quantidade_adquirida > 5)
                    {
                        desconto = total * 0.05;
                    }
            Console.WriteLine("o total de sua compra r$" + desconto);
            Console.ReadKey();

        }
    }
}
