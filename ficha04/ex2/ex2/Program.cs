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
            //dada uma string o programa retorna o numero de caracteres, espaços e vogais
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(10, 2);
            Console.Write("Introduza uma texto --> ");
            string frase = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(30, 2);
            Console.WriteLine(frase);
            Console.SetCursorPosition(10, 6);
            Console.Write("Nº caracteres : {0}", frase.Length);
            int esp=0, vog = 0; //variaveis contadoras dos espaços e vogais
            foreach (var ch in frase.ToUpper())
            {
                if (ch==' ')
                {
                    esp++;
                }
                if (ch=='A' || ch=='E'|| ch=='I'||ch=='O'||ch=='U')
                {
                    vog++;
                }
            }
            Console.SetCursorPosition(30, 6);
            Console.Write("Nº espaços : {0}", esp);
            Console.SetCursorPosition(55, 6);
            Console.Write("Nº Vogais : {0}", vog);
            Console.ReadKey();
        }
    }
}
