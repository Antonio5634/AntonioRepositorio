using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercicio_coleções
{
    class Program
    {
         public static Random haha = new Random();
         static void Main(string[] args)
         {
             List<int> lista = new List<int>();
             for (int i = 0; i < 7; i++)
             {
                 lista.Add(haha.Next(1, 100));
                 Console.WriteLine(lista[i]);
             }
             Console.WriteLine("Maior valor: " + lista.Max());
         }
    }
}
