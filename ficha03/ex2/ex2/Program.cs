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
            // dados dois numeros inteiros o programa deve devolver o minimo multiplo comum
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.Write("Insira o primeiro número --> ");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.SetCursorPosition(30, 12);
            Console.Write("Insira o segundo número --> ");
            int n2 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            int i = 1;
            List <int> n1listademultiplos = new List<int>();
            List<int> n2listademultiplos = new List<int>();
            bool flag = false;
            do
            {
                n1listademultiplos.Add(n1 * i);
                n2listademultiplos.Add(n2 * i);
                foreach (var numero in n1listademultiplos)
                {
                    if(n2listademultiplos.Contains(numero))
                    {
                        Console.SetCursorPosition(30, 10);
                        Console.Write("O MMC de {0} e {1} é {2}", n1, n2, numero);
                        flag = true;
                    }
                }
                i++;
            } while (flag==false);
            Console.ReadKey();
        }
    }
}
