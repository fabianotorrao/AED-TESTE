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
            //dada uma string o programa deve escrever o seu conteudo na ordem inversa
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Introduza uma frase --> ");
            string frase = Console.ReadLine();
            Console.Clear();
            frase =inverter(frase); 
            Console.Write("O seu texto inverso -- > {0}",frase);
            Console.ReadKey();
        }
        public static string inverter (string frase)
        {
            char[] arrchar = frase.ToCharArray();
            Array.Reverse(arrchar);
            return new string(arrchar);
        }
    }
}
