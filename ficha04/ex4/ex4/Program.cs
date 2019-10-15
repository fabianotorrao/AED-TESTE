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
            //dada uma string o programa deve remover os espaços duplos e substituir por apenas 1
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(20, 10);
            Console.Write("Introduza o texto a tratar --> ");
            string text = Console.ReadLine();
            Console.Clear();
            text=text.Replace("  ", " ");
            Console.Write("String tratada : {0}", text);
            Console.ReadKey();
        }
    }
}
