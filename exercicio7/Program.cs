using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    class Program
    {
        public static double comissao, valorVendas1, total_vendas;
        public static string nome;
        static void Main346794(string[] args)
        {
            Console.WriteLine("informe seu nome:");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("seu valor de vendas:");
            valorVendas = Convert.ToDouble(Console.ReadLine());

            if (valorVendas>50.000)
            {
                valorVendas = valorVendas*0.12; 

            }
            else if (valorVendas <= 50.000 && valorVendas >= 30.000)
            {
                valorVendas = valorVendas * 9.5;
            }
            else if (valorVendas >= 100.000)
            {
                valorVendas = valorVendas * 0.7;
            }
            
            

        }
    }
}
