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
            //dado 10 numeros inteiros o programa deve retornar a média e os valores cujo estejam acima da média
            int[] array = new int[10];
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(10, 15);
                Console.Write("Insira o {0}º número --> ",i+1);
                array[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            double media = array.Average();
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Média : {0}", media.ToString("##.##"));
            Console.SetCursorPosition(10, 12);
            Console.Write("Números acima da média : ");
            foreach (var registo in array)
            {
                if (registo>media)
                {
                    Console.Write(registo+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
