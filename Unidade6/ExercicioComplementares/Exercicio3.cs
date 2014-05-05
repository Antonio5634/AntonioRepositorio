using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioComplementares
{
    class Exercicio3
    {
         public static double peso_ideal_mulher, peso_ideal_homem, altura;
        public static int opcao;
        public static string homem, mulher;
        static void Main6676(string[] args)
        {
            Console.WriteLine("====Peso====");
            Console.WriteLine("digite sua opção calculo para obter o peso idead Mulher(1) ou Homem(2)?");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 2:
                    homem = "Homem";
                    Console.WriteLine("informese altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                    peso_ideal_homem = 72.7 * altura - 58;
                    Console.WriteLine("Seu Ideal é:" + peso_ideal_homem);
                    break;
                case 1:
                    mulher = "Mulher";
                    Console.WriteLine("informe sua altura:");
                    altura = Convert.ToDouble(Console.ReadLine());
                    peso_ideal_mulher = 62.1 * altura - 44.7;
                    Console.WriteLine("Seu ideia é:" + peso_ideal_mulher);
                    break;



            }
            Console.ReadKey();
        }
    }
}
