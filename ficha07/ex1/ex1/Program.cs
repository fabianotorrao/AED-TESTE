using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        //dado um array de 3X3 o programa deve listar o array escrito e gráficamente
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            lerdados(array);
            listar_escrito(array);
            
        }
        public static void listar_escrito(int[,]array)
        {
            
            Console.SetCursorPosition(15, 7);
            Console.Write("Dados do array:");
            int x = 10, y = 10;
            for (int i = 0; i < 3; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    Console.SetCursorPosition(x, y);
                    y++;
                    Console.Write("Linha {0} Coluna {1} Valor : {2}", i+1, i2+1, array[i, i2]);
                }
            }
            Console.SetCursorPosition(10, 25);
            tabelar(array);
            tabelar_transposta(array);

            Console.ReadKey();

        }
        public static void tabelar_transposta(int[,]array)
        {
            int x = 20, y = 25;
            Console.SetCursorPosition(10, 24);
            Console.Write("Matriz transposta");
            for (int i = 0; i < 3; i++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(+array[i1,i.]);
                    x = x + 2;
                }
                y++;
                x = 20;
            }
        }
        public static void tabelar(int[,]array)
        {
            int x = 10, y = 25;
            Console.SetCursorPosition(10, 24);
            Console.Write("Matriz original");
            for (int i = 0; i < 3; i++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(+array[i, i1]);
                    x=x+2;
                }
                y++;
                x = 10;
            }
        }
        public static void lerdados(int[,]array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                {
                    Console.SetCursorPosition(15, 15);
                    Console.Write("Insira o numero para a linha {0} e a coluna {1} -->", i + 1, i1 + 1);
                    array[i, i1] = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                }
            }
        }
    }
}
