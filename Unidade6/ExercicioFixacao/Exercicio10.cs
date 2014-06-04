using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioFixacao
{
    
    class Exercicio10
    {
        public static double preço_total, desconto, preço_inicial;
    
        public static char opcao;
        public static string nome;
        public static string tipo_pagamento;

        static void Main7576(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite o valor inicial");
            preço_inicial = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("O que o su carro possui?");
            Console.WriteLine("(1) possui carro eletrico:") ;
            Console.WriteLine("(2) possui ar condicinado:");
            Console.WriteLine("(3) possui trava/aarme:");
            Console.WriteLine("(4) possui direcao hidraulica");
            opcao = Convert.ToChar(Console.ReadLine());

            if (opcao == '1')
            {
                preço_total = preço_inicial + 500;
            }
            else
                if (opcao == '2')
                {
                    preço_total = preço_inicial + 2000;
                }
                else
                    if (opcao == '3')
                    {
                        preço_total = preço_inicial + 500;
                    }
                    else
                        if (opcao == '4')
                        {
                            preço_total = preço_inicial + 2500;
                        }

            Console.WriteLine("O preço final do seu carro sera:"+preço_total);

            Console.WriteLine("Deseja efetuar o pagamento a vista?Sim ou Nao"+tipo_pagamento);

            if(tipo_pagamento == "SIM")
            {
                desconto = preço_total-(preço_total*0.05);
                Console.WriteLine("o preço do seu carro á vista:  " + desconto);
            } 
            else
                if(tipo_pagamento == "NAO")
                {
                    Console.WriteLine("o valor ira continuar o mesmo:"+preço_total);
                }
            Console.ReadKey();



        }
        
    }
}
