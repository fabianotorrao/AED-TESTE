using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // o programa gera um numero e o utilizador tem de tentar acertar, em cada tentativa o programa
            // sugere se o numero é inferior ou não


            Random rnd = new Random(); //gerador do numero aleatório entre 1 e 50
            int numero_gerado = rnd.Next(1,50);
            int numero_utilizador = 0, tentativas=10;

            while (numero_utilizador == 0 || numero_utilizador != numero_gerado && tentativas>0)
            {
                
                Console.Clear();
                Console.WriteLine("Tentativas : {0}", tentativas); // mostra o numero de tentativas restantes
                Console.WriteLine();
                Console.Write("Introduza um numero --> ");
                numero_utilizador = Convert.ToInt16(Console.ReadLine()); // leitura do numero do utilizador
                Console.Clear();
                if (numero_utilizador>numero_gerado)
                {
                    Console.WriteLine("O numero gerado é menor");
                    tentativas--;

                }
                else if (numero_utilizador<numero_gerado)
                {
                    Console.WriteLine("O numero gerado é maior");
                    tentativas--;
                }
                else
                {
                    Console.WriteLine("Acertou!");
                    tentativas--;
                    Console.WriteLine("Usou {0} tentativas", 10 - tentativas);
                }
                if (tentativas == 0)
                {
                    Console.WriteLine("Game over !");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.ReadKey();

            }


        }
    }
}
