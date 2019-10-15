using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            // dado um texto em string o programa deve devolver o numero de ocorrrencias de uma determinada string e a sua posição
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Introduza o texto : ");
            string texto = Console.ReadLine();
            Console.Clear();
            string[] texto_separado = texto.Split(' ');
            Console.SetCursorPosition(30, 10);
            Console.Write("Introduza a palavra a pesquisar --> ");
            string procurar = Console.ReadLine();
            Console.Clear();
            int cntd = 0;
            Console.SetCursorPosition(30,5);
            Console.Write("Texto --> {0} ",texto);
            foreach (var palavra in texto_separado)
            {
                if (palavra==procurar)
                {
                    cntd++;
                }
            }
            Console.SetCursorPosition(35, 8);
            Console.Write("Palavra : {0}", procurar);
            Console.SetCursorPosition(35, 10);
            Console.Write("Numero de ocorrencias : {0}", cntd);
            Console.SetCursorPosition(35, 12);
            Console.Write("Posição : ");
            for (int i = 0; i < texto.Length-procurar.Length; i++)
            {
                if(texto.Substring(i, procurar.Length)==procurar)
                {
                    Console.Write(i+" ");
                }

            }
            Console.ReadKey();
             
                
        }
    }
}
