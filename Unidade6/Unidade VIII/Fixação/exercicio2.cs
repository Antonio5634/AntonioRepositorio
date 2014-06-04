using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII
{
    class exercicio2
    {
        public static int espaco;


        static void Main8685(string[] args)
        {
            //Console.WriteLine("==============");
            //Console.WriteLine(" ==============");
            //Console.WriteLine("  ==============");
            //Console.WriteLine("   ==============");
            //Console.WriteLine("    ==============");
            //Console.WriteLine("==============");
            //Console.WriteLine(" ==============");
            //Console.WriteLine("  ==============");
            //Console.WriteLine("   ==============");
            //Console.WriteLine("    ==============");
            //Console.WriteLine("==============");
            //Console.WriteLine(" ==============");
            //Console.WriteLine("  ==============");
            //Console.WriteLine("   ==============");
            //Console.WriteLine("    ==============");

            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine("**********");
                Contadorespaco();
                espaco += 1;
            }

            espaco = 0;
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine("**********");
                Contadorespaco();
                espaco += 1;
            }

            espaco = 0;
            for (int j = 1; j <= 6; j++)
            {
                Console.WriteLine("**********");
                Contadorespaco();
                espaco += 1;
            }



            Console.ReadLine();
        }
        private static void Contadorespaco()
        {

            for (int i = 0; i < espaco + 1; i++)
            {

                Console.Write(" ");
            }
        }
    }
}
