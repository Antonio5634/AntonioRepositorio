﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_coleções
{
    class exercicio2
    {
        public static Random haha = new Random();
        static void Main7(string[] args)
        {
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                lista1.Add(haha.Next(0, 10));
                Console.WriteLine(" vetor: " + lista1[i]);

            }
        }
    }
}
