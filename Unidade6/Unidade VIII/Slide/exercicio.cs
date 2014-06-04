using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII.Slide
{
    class exercicio
    {
        static void Main43()
        {
            Random cor = new Random();

            double roupa = cor.NextDouble() * 10;

            Console.WriteLine("valor ", roupa);

            if (roupa > 0.5)
            {
                Console.WriteLine("Vermelha");
            }
            else
            {
                Console.WriteLine("Azul");
            }      

        }
    }
}
