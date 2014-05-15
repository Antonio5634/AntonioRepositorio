using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII.Repeticoes
{
    class exercicio6
    {
        static void Main6557(string[] args)
        {
            for (int i = 1; i < 4; i++)
            {
                int t = i;
                while (t < 100)
                {
                    Console.WriteLine("Setor: "+i+" Cadeira:"+t);
                    t++;
                }
          
            }
         Console.ReadKey();
        }
    }
    
}
