using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        public static Double peso;
        public static int opcao;
        //escolhido um planeta o programa devolve o peso dado correspondente em outros planetas
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("******************************************************************");
                Console.WriteLine("* CODIGO DO PLANETA          Planeta          Gravidade Relativa *");//10 EM 10 ESPACOS
                Console.WriteLine("*       1                  Mercurio                  0.37        *");
                Console.WriteLine("*       2                   Vénus                    0.88        *");
                Console.WriteLine("*       3                   Marte                    0.38        *");
                Console.WriteLine("*       4                  Júpiter                   2.64        *");
                Console.WriteLine("*       5                  Saturno                   1.15        *");
                Console.WriteLine("*       6                   Urano                    1.17        *");
                Console.WriteLine("******************************************************************");
                Console.WriteLine("");
                Console.Write("Escolha a sua opção --> ");
                opcao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

            double peso = 0;
            if (opcao>=1&&opcao<=6)
            {
                Console.Write("Introduza o peso a converter (KG) --> ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }


            //decisão
            peso=Decisao(opcao,peso);
            if (opcao >= 1 && opcao <= 6)
            {
                Console.WriteLine("O seu peso simulado corresponde a {0}", Math.Round(peso, 2));
                Console.ReadKey();
            }


            }
        public static  Double Decisao (int opcao,double peso)
        {
            switch (opcao)
            {
                case 1:
                    peso = peso * 0.37;
                    
                    break;
                case 2:
                    peso = peso * 0.88;
                    break;
                case 3:
                    peso = peso * 0.38;
                    break;
                case 4:
                    peso = peso * 2.64;
                    break;
                case 5:
                    peso = peso * 1.15;
                    break;
                case 6:
                    peso = peso * 1.17;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    break;
            }
            return peso;
        }
    }
}
