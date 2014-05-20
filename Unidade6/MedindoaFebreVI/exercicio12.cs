using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.MedindoaFebreVI
{
    class exercicio12
    {
        public static int matricula, nota1, nota2, nota3, aulas_comparecidas,alun,media,total,alunos,au1,au2;
        public static Random notas = new Random();
        static void Main7676(string[] args)
        {
            Console.WriteLine("informe sua  matricula:");
            matricula = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine("informe a quantidade de alunos:");
                alunos = Convert.ToInt32(Console.ReadLine());
                

                nota1 = notas.Next(10, 100);
                nota2 = notas.Next(10, 100);
                nota3 = notas.Next(10, 100);
                media = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine("Media: " + media);
                if (media >= 60)
                {
                    au1 = au1 + 1;
                    Console.WriteLine("esta aprovado");
                }
                else
                {
                    Console.WriteLine("esta reprovado");
                }
                Console.WriteLine("informe sua frequencia sendo que o minimo é 40: ");
                aulas_comparecidas = Convert.ToInt32(Console.ReadLine());
                if (aulas_comparecidas > 40)
                {
                    Console.WriteLine("esta aprovado");
                }
                else
                {

                    Console.WriteLine("esta reprovado");
                    
                }
                if (media < 60 || aulas_comparecidas < 40)
                {
                    au2 = au2 + 1;
                    Console.WriteLine("reprovado");
                }


                i++;
                
            } while (i++ == total);
            Console.WriteLine("quantidade de aprovados:" + au1);
            Console.WriteLine("quantidade de reprovados:"+au2);
            Console.ReadKey();
            
           
        }

    }
}
