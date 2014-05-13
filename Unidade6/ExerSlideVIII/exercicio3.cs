using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII
{
    class exercicio3
    {
        public static Random escolhe = new Random();
        public static double caminho;
        static void Main7678(string[] args)
        {
            double caminho = escolhe.NextDouble() * 10;
            Console.WriteLine(caminho);
            if (caminho>=0.5)
            {
                Console.WriteLine("siga a direita ");

            }
            else
            {
                Console.WriteLine("siga a esquerda");
            }
            Console.ReadKey();

        }
    }
}
