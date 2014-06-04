using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_VII
{
    class exercicio6
    {
        static void Main67()
        {
            Random random = new Random();
            int conNumero = 0;
            int numero = random.Next();
            char[] numeros = numero.ToString().ToCharArray();

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == '1')
                {
                    conNumero++;
                }
            }
            Console.WriteLine(numero);
            Console.WriteLine(conNumero);
            Console.ReadKey();
        }
        
    }
}
