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
            // dado um nome próprio o programa deve abreviar os nomes intermédios mantendo o primeiro e o ultimo
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Insira o nome a tratar : ");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            string[] nome_separado = nome.Split(' ');
            if (nome_separado.Count()==1)
            {
                Console.Write("Só existe um nome : {0}",nome_separado[0]);
            }
            else if(nome_separado.Count()==2)
            {
                Console.Write("Existem dois nomes : {0} {1}", nome_separado[0], nome_separado[1]);
            }
            else
            {
                Console.Write("Nome abreviado : {0} ",nome_separado[0]);
                for (int i = 1; i <= nome_separado.Count()-1; i++)
                {
                    if (nome_separado.Count()-1==i)
                    {
                        Console.Write(nome_separado[i]);
                    }
                    else
                    {
                        Console.Write(nome_separado[i].ToUpper()[0] + ". ");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
