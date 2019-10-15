using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Jogo avidinha o numero";
            char opcao = 'S';
            while (opcao == 'S')
            {
                jogo();
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("***************************************");
                Console.SetCursorPosition(40, 11);
                Console.WriteLine("* Deseja jogar novamente?(S/N)  --> _ *");
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("***************************************");
                Console.SetCursorPosition(76, 11);
                opcao = Convert.ToChar( Console.ReadLine().ToUpper());


            }

        }
        public static void jogo() //funcao de jogo
        {
            Random rnd = new Random(); //gerador do numero aleatório entre 1 e 50
            int numero_gerado = rnd.Next(1, 50);
            int numero_utilizador = 0, tentativas = 10;

            while (numero_utilizador == 0 || numero_utilizador != numero_gerado && tentativas > 0)
            {

                Console.Clear();
                Console.SetCursorPosition(104,0);
                Console.Write("Tentativas : {0}", tentativas); // mostra o numero de tentativas restantes
                Console.SetCursorPosition(40, 10);
                Console.Write("***************************************");
                Console.SetCursorPosition(40, 11);
                Console.Write("* Introduza um numero --> _           *");
                Console.SetCursorPosition(40,12);
                Console.Write("***************************************");
                Console.SetCursorPosition(66, 11);
                numero_utilizador = Convert.ToInt16(Console.ReadLine()); // leitura do numero do utilizador
                Console.Clear();
                Console.SetCursorPosition(40, 10);
                Console.Write("***************************************");
                Console.SetCursorPosition(40, 12);
                Console.Write("***************************************");
                Console.SetCursorPosition(40, 11);
                if (numero_utilizador > numero_gerado)
                {
                    Console.Write("*    O numero gerado é menor          *");
                    tentativas--;

                }
                else if (numero_utilizador < numero_gerado)
                {
                    Console.Write("*   O numero gerado é maior           *");
                    tentativas--;
                }
                else
                {
                    Console.Write("*             Acertou!                *");
                    tentativas--;
                    Console.SetCursorPosition(100, 0);
                    Console.Write
                        
                        ("Usou {0} tentativas", 10 - tentativas);
                }
                if (tentativas == 0)
                {
                    Console.SetCursorPosition(45, 14);
                    Console.Write("         GAME OVER!            ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.ReadKey();
            }
        }
    }
}
