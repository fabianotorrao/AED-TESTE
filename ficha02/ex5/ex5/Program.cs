using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // dado um numero o programa devolve o valor do seu fatorial
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.Write("Insira um numero inteiro --> ");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            int resultado = 1;
            if (numero == 0)
            {
                Console.Write("O fatorial de : 0      Resultado : 1");
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado = resultado* i;
                }
                Console.Write("O fatorial de : {0}      Resultado : {1}",numero,resultado);
            }
            Console.ReadKey();
               
        }
    }
}
