using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            //dados 10 numeros inteiros o programa após dado um numero para pesquisa deve devolver se esse numero existe ou nao e as vezes que se repete
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(10, 10);
                Console.Write("Introduza o {0}º numero --> ", i + 1);
                numeros[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            Console.SetCursorPosition(10, 10);
            Console.Write("Insira o numero a pesquisar --> ");
            int pesq = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(15, 15);
            if (Array.IndexOf(numeros, pesq) == -1)
            {

                Console.Write("O numero {0} não existe no array", pesq);
            }
            else
            {
                Console.Write("O numero {0} encontra-se na posição {1}", pesq, Array.IndexOf(numeros, pesq));
                Console.SetCursorPosition(15, 16);
                int ct = 0;
                foreach (var registo in numeros)
                {
                    if (registo==pesq)
                    {
                        ct++;
                    }
                }
                Console.Write("O numero aparece {0} vezes",ct);
            }
            Console.ReadKey();
        }
    
    }
}
