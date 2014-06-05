using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.UnidadeVII
{
    class exercicio5
    {
        public static int valor;
        static void Main453()
        {
           

            Console.WriteLine("Informe o valor  ");
            valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0){
                Console.WriteLine("Digite um numero ímpar");
            }

            int[] arr = new int[valor];


            for (int a = 1; a <= arr.Length; a++)
            {
                Console.Write(+a);
                Console.WriteLine((a + 1) - 1);
            }
        }
    }
}
