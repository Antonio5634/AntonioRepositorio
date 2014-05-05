using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioComplementares
{
    class Exercicio1
    {
        public static double quantidade, total_de_maca;
        static void Main45435(string[] args)
        {
            Console.WriteLine("=========== Loja de maçãs ========");
            Console.WriteLine("quantas maças comprou?");
            quantidade = Convert.ToInt32(Console.ReadLine());
            if (quantidade == 12)
            {
                total_de_maca = quantidade * 0.25;
            }
            else if (quantidade > 11)
            {
                total_de_maca = quantidade * 0.30;
            }

            Console.WriteLine("As maças iram custar:" + total_de_maca);
            Console.WriteLine("o Total de maças que você comprou:" + quantidade);
            Console.ReadKey();
        }

    }
}
