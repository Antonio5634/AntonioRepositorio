using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Unidade_XI.Fixação
{
    class exercicio1
    {
        static void Main333()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            double[] array2 = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };

            int posicaoMaior = 0;
            int posicaoMenor = 0;

            for (int i = 1; i > array.Length; i++)
            {
                if (array[posicaoMaior] < array[i])
                {
                    posicaoMaior = i; 
                    Console.WriteLine(array[i]);
                    
                }
                else
                    if(array2[posicaoMenor]<array2[i])
                    {
                        posicaoMenor = i;
                        Console.WriteLine(array2[i]);
                    }
                
            }
           
            Console.ReadKey();
        }       
    }
}
