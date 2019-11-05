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
            //dado dois arrays de n dimensao o programa deve juntar os registos num terceiro, devidamente ordenados
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
                if (n!=-1)
                {
                    Array.Resize(ref array1, array1.Length + 1);
                    array1[array1.Length-1] = n;
                }
            } while (n!=-1);
            Array.Sort(array1);
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
                    array2[array2.Length-1] = n;
                }
            } while (n != -1);
            Array.Sort(array2);
            double[] array3 = new double[0];
            for (int i = 0; i < array1.Length; i++)
            {
                Array.Resize(ref array3, array3.Length + 1);
                array3[array3.Length - 1] = array1[i];

            }
            for (int i = 0; i < array2.Length; i++)
            {
                Array.Resize(ref array3, array3.Length + 1);
                array3[array3.Length - 1] = array2[i];
            }
            Array.Sort(array3);
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
            Console.Write("Array 3 (merge do 1 e 2) : ");
            foreach (var registo in array3)
            {
                Console.Write(registo + " ");
            }
            Console.ReadKey();
        }
        
    }
}
