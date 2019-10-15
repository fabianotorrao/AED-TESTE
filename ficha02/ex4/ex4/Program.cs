using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // o programa gera um ano aleatório e devolve a sua classificação
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Random rnd = new Random();
            int ano=rnd.Next(1900, 2016);
            Console.SetCursorPosition(40,10);
            if((ano%400)==0||(ano%4)==0)
            {
                Console.Write("O ano {0} é bissexto",ano);
                
            }
            else
            {
                Console.Write("O ano {0} não é bissexto", ano);
            }
            Console.ReadKey();
        }
    }
}
