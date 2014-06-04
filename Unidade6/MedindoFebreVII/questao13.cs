using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.MedindoFebreVII
{//13)	Implemente um algoritmo que armazene a idade, nome, sexo, altura, se é adulto ou não. 
    //Esses vetores devem ter 50 posições cada um. O algoritmo deve ter métodos ou funções para inicializar seus vetores com os dados, 
    //os valores de idade, altura, sexo e se é adulto ou não, podem ser gerados aletoriamente.
    //- A porcentagem dos que são adultos e dos que não são; 
    //- A porcentagem do sexo masculino e feminino;
    //- A porcentagem dos mais altos que 1,70m;
    //- Listar todos da seguinte maneira:  Nome: Thiago Sartor, Idade: 23, Sexo: ‘M’, Adulto: true
    //- Listar os 10 mais velhos;
    //- Listar os 5 mais novos;
    //- Listar a pessoa mais alta;
    //- Listar a pessoa mais baixa;


    class Questao13
    {
        public static double aum =0, conauf=0, auI=0;
        public static Random idade = new Random();
        static  char sexo;
        static void Main345(string[] args)
        {
            int[] posicoes = new int[50];
            char[] sexo = new char []{'M','F'};
            int[] altura = new int[2];
            int anos = idade.Next(17, 99);
            string[] nome = new string[50];
           int aum =0, conauf=0, auI=0;



           //string teste;
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine(nome[i] + ("teste" + i+":") + sexo[i] + "sexo:  " + altura[i] + "altura:  " + "Idade: " + anos);
                    //Console.WriteLine(sexo[i] + "sexo:");
                    //Console.WriteLine(altura[i] + "altura");
                    //Console.WriteLine("Idade:" + anos);

                    if(anos>18)
                    {
                        
                        Console.WriteLine("se considere adulto");
                        anos = auI+1;
                    }
                    else
                        if( 'm'==sexo[i])
                        {
                           
                            aum++;
                           
                        }
                        else
                            if('f' == sexo[i]) 
                            {
                                
                                conauf++;
                                
                                
                            }
                            else
                                if(altura[i]>altura[i])
                                   altura[i]=altura[i];
                    
                    if(altura[i]<altura[i])
                        altura[i]=altura[i];
                     
                    double percentualSexoM = ( aum * 100) / 50;
                    double percentualSexoF = (conauf *100) /50;
                    double percetualAnos = (auI*100)/50;
                }
                 

                
        }
    }
}
    
    