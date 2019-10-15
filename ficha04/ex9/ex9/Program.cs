using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            // dado um texto o programa deve identificar os valores numerais e escrever
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Insira a frase -->");
            string frase = Console.ReadLine();
            Console.Clear();
            string[] frasecortada = frase.Split(' ');
            Console.SetCursorPosition(30, 10);
            Console.Write("Texto tratado --> ");
            foreach (var palavra in frasecortada)
            {
                switch (palavra)
                {
                    case "0":
                        Console.Write("zero ");
                        break;
                    case "1": Console.Write("um ");
                        break;
                    case "2":
                        Console.Write("dois ");
                        break;
                    case "3":
                        Console.Write("três ");
                        break;
                    case "4":
                        Console.Write("quatro ");
                        break;
                    case "5":
                        Console.Write("cinco ");
                        break;
                    case "6":
                        Console.Write("seis ");
                        break;
                    case "7":
                        Console.Write("sete ");
                        break;
                    case "8":
                        Console.Write("oito ");
                        break;
                    case "9":
                        Console.Write("nove ");
                        break;

                    default: Console.Write(palavra+" ");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
