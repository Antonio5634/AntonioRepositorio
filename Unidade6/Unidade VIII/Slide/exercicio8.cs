using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII.Slide
{
    class exercicio8
    {
        public static string castigo;
        static void Main()
        {

            int i = 0;
            castigo = "Não andarei de skate nos corredores";
                while (i<100)
                { 
                    
                    Console.WriteLine(i+"Frase: " + castigo);
                    
                }
            

            Console.ReadKey();
        }
    }
}
