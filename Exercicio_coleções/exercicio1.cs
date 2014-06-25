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
        public static ArrayList _ArrayList = new ArrayList();
        static void Main(string[] args)
        {
            for (int i = 1; i <100; i++)
            {
                _ArrayList.Add(i);
                _ArrayList.RemoveAt(1);
                _ArrayList.Sort();//crescente
                 _ArrayList.Reverse(); //decrescente
            }
            Console.ReadKey();
        }
    }
}
