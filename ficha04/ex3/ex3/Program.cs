using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //dada um texto o programa deve devolver se o inserido é capicua ou não
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Introduza uma frase --> ");
            string frase = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            if (frase==inverter(frase))
            {
                
                Console.Write("O texto é capicua");
            }
            else
            {
                Console.Write("O texto não é capicua");
            }
            Console.ReadKey();
            
            
        }
        public static string inverter(string frase)
        {
            char[] arrchar = frase.ToCharArray();
            Array.Reverse(arrchar);
            return new string(arrchar);
        }
    }
}
