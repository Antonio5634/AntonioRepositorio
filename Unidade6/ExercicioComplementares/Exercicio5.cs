using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioComplementares
{
    class Exercicio5
    {
        public static double contrato, quantidade_caixas, idade;

        static void Main32(string[] args)
        {
            Console.WriteLine("informe quantos pessoas irá contratar:");
            contrato = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quantas caixas iram colher:");
            quantidade_caixas = Convert.ToDouble(Console.ReadLine());
            if (quantidade_caixas > 5)
            {
                quantidade_caixas = quantidade_caixas * 2.00;
            }
            else
                if (quantidade_caixas < 6 && quantidade_caixas > 10)
                {
                    quantidade_caixas = quantidade_caixas * 2.50;
                }
                else
                    if (quantidade_caixas < 11 && quantidade_caixas > 20)
                    {
                        quantidade_caixas = quantidade_caixas * 3.50;
                    }
                    else
                        if (quantidade_caixas < 21)
                        {
                            quantidade_caixas = quantidade_caixas * 5.00;
                        }
            Console.WriteLine("informe sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18 && idade > 45)
            {
                idade = quantidade_caixas * 0.10;
            }
            else
                if (idade != 18 && idade > 45)
                {
                    idade = idade * 0.010;
                }
                else
                    if (idade < 45 && idade > 65)
                    {
                        idade = idade * 0.20;
                    }
            Console.WriteLine("Quanto irá receber de quantas caixas carregadas" + quantidade_caixas);
            Console.WriteLine("Quanto sera o adicional" + idade);
            Console.ReadKey();

        }

    }
}
