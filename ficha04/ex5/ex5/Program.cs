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
            // dado um nome completo o programa deve devolver o primeiro e ultimo nome
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Insira o nome completo --> ");
            string nomecompleto = Console.ReadLine();
            Console.Clear();
            string [] nomeseparado = nomecompleto.Split(' ');
            Console.SetCursorPosition(30, 10);
            Console.Write("Primeiro e ultimo nome : {0} {1}", nomeseparado[0], nomeseparado[nomeseparado.Count()-1]);
            Console.ReadKey();


        }
    }
}
