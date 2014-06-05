using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.UnidadeVII
{
    class exercicio2
    {
        public static double media_salario, quant_filhos, maior_salario, percentual;
        static void Main76768(string[] args)
        {
            Console.WriteLine("informe a media salarial:");
            media_salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe quantidade de filhos:");
            quant_filhos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe o maior salario da cidade:");
            maior_salario = Convert.ToDouble(Console.ReadLine());
            percentual = (media_salario + maior_salario) / quant_filhos;
            if (percentual < 150)
            {
                Console.WriteLine("voces estao mals");
            }
            Console.WriteLine("Média de salário da população: " + media_salario);
            Console.WriteLine("Média do número de filhos: " + quant_filhos);
            Console.WriteLine("Maior salário dos habitantes: " + maior_salario);
            Console.WriteLine("Média do salario dividido por filho: " + percentual);
            Console.ReadKey();

        }
    }
}
