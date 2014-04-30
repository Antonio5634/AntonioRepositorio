using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioFixacao
{
    class Exercicio8
    {
        public static double comissao, valorVendas,corretor1,corretor2,corretor3, total_vendas;
        public static string nome;
        static void Main4538(string[] args)
        {
            Console.WriteLine("informe seu nome:");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("seu valor de vendas:");
            corretor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("seu valor de vendas:");
            corretor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("seu valor de vendas:");
            corretor3 = Convert.ToDouble(Console.ReadLine());
            valorVendas = corretor1 + corretor2 + corretor3;

            if (valorVendas > 50.000)
            {
                valorVendas = valorVendas * 0.12;

            }
            else if (valorVendas <= 50.000 && valorVendas >= 300000)
            {
                valorVendas = valorVendas * 9.5;
            }
            else if (valorVendas >= 100000.00)
            {
                valorVendas = valorVendas * 0.7;
            }
            Console.WriteLine("total de vendas da  empresa:" + valorVendas);
            Console.ReadKey();


        }
    }
}
