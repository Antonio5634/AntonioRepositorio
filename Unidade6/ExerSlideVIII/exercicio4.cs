using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII
{
    class exercicio4
    {
        public static Random escolha = new Random();
        public static double camisa;

        static void Main454(string[] args)
        {
            double camisa = escolha.NextDouble() * 0.5;
            Console.WriteLine(camisa);
            if (camisa >= 0.5)
            {
                Console.WriteLine("compre a camisa Azul");
            }
            else
            {
                Console.WriteLine("compre nenhuma poha");
            }
            Console.ReadKey();
        }
    }
   
    
}
