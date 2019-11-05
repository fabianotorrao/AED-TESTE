using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //dado dois arrays o programa deve devolver quantos elementos do 1º pertencem ao 2º
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            double[] array1 = new double[0];
            double n;
            do
            {

                Console.SetCursorPosition(10, 10);
                Console.Write("Insira um numero para o array 1 (-1 para terminar) --> ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (n != -1)
                {
                    Array.Resize(ref array1, array1.Length + 1);
                    array1[array1.Length - 1] = n;
                }
            } while (n != -1);
            double[] array2 = new double[0];
            do
            {
                Console.SetCursorPosition(10, 10);
                Console.Write("Insira um numero para o array 2 (-1 para terminar) --> ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (n != -1)
                {
                    Array.Resize(ref array2, array2.Length + 1);
                    array2[array2.Length - 1] = n;
                }
            } while (n != -1);
            int ct = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array2.Contains(array1[i]))
                    {
                        ct++;
                    }
                }
            Console.SetCursorPosition(10, 10);
            Console.Write("Array 1 : ");
            foreach (var registo in array1)
            {
                Console.Write(registo + " ");
            }
            Console.SetCursorPosition(10, 12);
            Console.Write("Array 2 : ");
            foreach (var registo in array2)
            {
                Console.Write(registo + " ");
            }
            Console.SetCursorPosition(10, 14);
            Console.Write("{0} elementos do array 1 pertencem também ao array 2",ct);
            Console.ReadKey();
        }
    }
}
