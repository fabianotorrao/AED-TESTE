using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            // dada uma string o programa deve separa palavra a palavra em duas strings diferentes alternadamente
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Introduza uma frase -->");
            string[] texto = Console.ReadLine().Split(' ');
            Console.Clear();
            string string1 = "", string2 = "";
            for (int i = 0; i < texto.Count(); i+=2)
            {
                string1 = string1 + texto[i]+" ";
            }
            for (int i = 1; i < texto.Count(); i+=2)
            {
                string2 = string2 + texto[i]+" ";
            }
            Console.SetCursorPosition(30, 10);
            Console.Write("String 1 : {0}", string1);
            Console.SetCursorPosition(30, 12);
            Console.Write("String 2 : {0}", string2);
            Console.ReadKey();
        }
    }
}
