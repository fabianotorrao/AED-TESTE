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
            // dado os limites de uma matriz bidimensional o programa deve a preencher aleatóriamente e listar esses dados
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int opcao = 0;
            Console.SetCursorPosition(10, 10);
            Console.Write("Insira os limites de linas do array --> ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.Write("Insira os limites de colunas do array --> ");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Int32[,] array = new Int32[n, n1];
            Console.Clear();
            bool at = false;
            do
            {
                
                Console.SetCursorPosition(20, 9);
                Console.Write("********************************");
                Console.SetCursorPosition(20, 10);
                Console.Write("*       1 - Iniciar matriz     *");
                Console.SetCursorPosition(20, 11);
                Console.Write("*  2 - Imprimir m. transposta  *");
                Console.SetCursorPosition(20, 12);
                Console.Write("*     3 - Valor máximo         *");
                Console.SetCursorPosition(20, 13);
                Console.Write("*          0 - Sair            *");
                Console.SetCursorPosition(20, 14);
                Console.Write("********************************");
                Console.SetCursorPosition(20, 16);
                Console.Write("Introduza a sua opcao --> ");
                opcao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                
                switch (opcao)
                {
                    case 1:
                        array=iniciar_matriz(array,n,n1);
                        at = true;
                        
                        break;
                    case 2:
                        if (at==true)
                        {
                            Listar(array, n, n1);
                        }
                        else
                        {
                            Console.SetCursorPosition(15, 15);
                            Console.Write("Escolha a opção 1 para inicializar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        
                        break;
                    case 3:
                        if (at == true)
                        {
                            maximo(array, n, n1);
                        }
                        else
                        {
                            Console.SetCursorPosition(15, 15);
                            Console.Write("Escolha a opção 1 para inicializar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }
        public static void maximo(Int32[,] array, int n, int n1)
        {
            int max = -1,l=0,c=0;
            for (int i = 0; i < n; i++)
            {
                for (int i1 = 0; i1 < n1; i1++)
                {
                    if (array[i,i1]>=max)
                    {
                        max = array[i, i1];
                        c = i1;
                        l = i;
                    }
                }
            }
            Console.SetCursorPosition(15, 15);
            Console.Write("O valor máximo é {0}", max);
            Console.SetCursorPosition(15, 16);
            Console.Write("Linha : {0}", l+1);
            Console.SetCursorPosition(15, 17);
            Console.Write("Coluna : {0}", c+1);
            Console.ReadKey();
            Console.Clear();

        }
        public static void Listar(Int32[,] array,int n,int n1)
        {
            Console.Clear();
            Console.SetCursorPosition(15, 10);
            Console.Write("Matriz transposta:");
            int x=15,y = 12;
            for (int i = 0; i < n; i++)
            {
                for (int i1 = 0; i1 < n1; i1++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(array[i, i1]);
                    x = x + 3;
                }
                y++;
                x = 15;
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static Int32[,] iniciar_matriz(Int32[,]array,int n,int n1)
        {

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int i1 = 0; i1 < n1; i1++)
                {
                    array[i, i1] = rnd.Next(101);
                }
            }
            return array;

        }
    }
}
