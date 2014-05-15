using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.ExerSlideVIII.fluxo
{
    class exercicio1
    {
        public static Random jogo = new Random();
        public static  int jogador,soma;
        static void Main67(string[] args)
        {
            int i = 1;
            while( i>100)
                
                 jogador = jogo.Next(0,7);
            soma =soma+jogador;

            
            Console.WriteLine("total:" + soma);
            


                if (soma <= 19)
                {

                    Console.WriteLine("voce ganhou");
                }
                else
                {
                    Console.WriteLine("voce nao conseguiu");
                }
            Console.ReadKey();

           
            
        }
    }
}
