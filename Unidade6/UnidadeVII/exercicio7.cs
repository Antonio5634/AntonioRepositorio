using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.UnidadeVII
{
    class exercicio7
    {
        public static int idade;
        static void Main565(string[] args)
        {
            Console.WriteLine("informe sua idade");
            idade = Convert.ToInt32(Console.ReadLine());
            string resutadoIdade = idade >= 18 ? "se considere Adulto" : "Ops você nao é um adulto";
            Console.WriteLine(idade >= 18 ? "se considere Adulto" : "Ops você nao é um adulto");
            Console.ReadKey();
        }

    }
}
