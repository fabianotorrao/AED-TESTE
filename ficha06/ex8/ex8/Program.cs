using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //dado n numeros pelo utilizador o programa deve guardar num array e de seguida copiar para outro sem os repetir
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.Write("Insira quantos numeros vai inserir --> ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            int[] numeros = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(10, 10);
                Console.Write("Insira o {0}º numero --> ",i+1);
                numeros[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            Array.Sort(numeros);
            int i1 = 0;
            int[] numeros_sem_repetidos = new int[0];
            for (int i = 0; i < n; i++)
            {
                if (!numeros_sem_repetidos.Contains(numeros[i]))
                {
                    Array.Resize(ref numeros_sem_repetidos, numeros_sem_repetidos.Length + 1);
                    numeros_sem_repetidos[i1] = numeros[i];
                    i1++;
                }
            }
            listar(numeros, numeros_sem_repetidos);
            Console.ReadKey();
        }
        public static void listar(int[]numeros,int[]numeros_sem_repetidos)
        {
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.Write("array inicial : ");
            foreach (var registo in numeros)
            {
                Console.Write(registo + " ");
            }
            Console.SetCursorPosition(10, 12);
            Console.Write("Array processado :");
            foreach (var registo in numeros_sem_repetidos)
            {
                Console.Write(registo + " ");
            }
        }
    }
}
