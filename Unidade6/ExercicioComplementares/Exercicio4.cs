using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioComplementares
{
    class Exercicio4
    {
        public static Random gols = new Random();
        public static int gremio, inter;
        static void Main454(string[] args)
        {
            int gremio = gols.Next(0, 5);
            int inter = gols.Next(0, 5);
            Console.WriteLine("Gremio:" + gremio);

            Console.WriteLine("Inter:" + inter);

            if (gremio < inter)
            {
                Console.WriteLine("É campeão");
            }
            else
                if (gremio > inter)
                {
                    Console.WriteLine("É campeão");
                }
                else
                    if (gremio == inter)
                    {
                        Console.WriteLine("EMPATES");
                    }
            Console.ReadKey();
        }

    }
}
