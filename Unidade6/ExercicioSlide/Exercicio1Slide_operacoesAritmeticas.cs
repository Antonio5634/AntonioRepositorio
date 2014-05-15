using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExercicioSlide
{
    class Exercicio1Slide_operacoesAritmeticas
    {
        
        static void Main32432(string[] args)
        {
            // double a = 5;
            //double b = 2;
            //Console.WriteLine(1+"testando" +2+3);
            //Console.WriteLine("testando" + 1 + 2 + 3);
            ////double a = (double)5 / 2;
            ////double b = ((double)5 / (double)2);
            //Math.Pow(a, b);

            int a = 0;
            for (int i = 1; i < 10; i++)
            {
                if (i == 3 || i == 5)
                {
                    continue;
                }
                if (i == 9)
                {
                    break;
                }
                a += i;
            }

            Console.WriteLine(a);    
            Console.ReadKey();


        }
    }
}
