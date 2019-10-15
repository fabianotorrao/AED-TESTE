using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //dado um numero o programa devolve se é primo ou não

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.Write("Introduza um numero inteiro --> ");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            int divisores=0;
            for (int i = 1; i <= numero; i++)
            {
                if ((numero%i)==0)
                {
                    divisores++;
                }
            }
            Console.SetCursorPosition(40, 10);
            if (divisores == 2)
            
                Console.Write("O número é primo");
            
            else
                Console.Write("O número não é primo");
            Console.ReadKey();
        }
    }
}
