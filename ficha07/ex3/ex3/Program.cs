using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //o programa deve simular a gestao de um parque de estacionamento, podendo-se adicionar um carro, retirar e ver os estado
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int opcao = 0;
            bool[,] parque = new bool[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int i1 = 0; i1 < 5; i1++)
                {
                    parque[i, i1] = false;
                }
            }

            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 9);
                Console.Write("********************************");
                Console.SetCursorPosition(20, 10);
                Console.Write("*    1 - Entrada de veiculo    *");
                Console.SetCursorPosition(20, 11);
                Console.Write("*    2 - Saída de veiculo      *");
                Console.SetCursorPosition(20, 12);
                Console.Write("*    3 - Estado do parque      *");
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
                        entrada(parque);
                        break;
                    case 2:
                        saida(parque);
                        break;
                    case 3:
                        lugares_livres(parque);
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }
        public static void lugares_livres (bool[,]parque)
        {
            //lugares livres por fila
            Console.SetCursorPosition(12, 10);
            Console.Write("Lugares livres:");
            int y1 = 13; ;

            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(10, y1);
                Console.Write("Fila {0} : ", i + 1);
                int ct = 0;
                for (int i1 = 0; i1 < 5; i1++)
                {
                    if (parque[i, i1]==true)
                    {
                        ct++;
                    }
                    
                }
                Console.Write(5-ct);
                y1++;
            }
            Console.ReadKey();
        }
        public static void saida(bool[,]parque)
        {
            bool vazio = true;
            for (int i = 0; i < 3; i++)
            {
                for (int i1 = 0; i1 < 5; i1++)
                {
                    if (parque[i,i1]==true)
                    {
                        vazio = false;
                    }
                }
            }
            int f, l;
            if (vazio==false)
            {
                Console.SetCursorPosition(10, 10);
                Console.Write("Insira a fila --> ");
                f = Convert.ToInt16(Console.ReadLine())-1;
                Console.SetCursorPosition(10, 12);
                Console.Write("Insira o lugar --> ");
                l = Convert.ToInt16(Console.ReadLine())-1;
                Console.Clear();
                Console.SetCursorPosition(15, 15);
                if (parque[f,l]==true)
                {
                    parque[f, l] = false;
                    Console.Write("Carro retirado");
                }
                else
                {
                    Console.Write("Lugar vazio, sem veiculo a tirar");
                }
                Console.ReadKey();
            }
        }
        public static void entrada(bool[,]parque)
        {
            bool estacionado = false;
            Console.SetCursorPosition(15, 15);
            for (int i = 0; i < 5; i++)
            {
                if (parque[0,i]==false)
                {

                    Console.Write("Parque : fila 1 lugar : {0}",i+1);
                    parque[0, i] = true;
                    break;
                }
                else if (i==4)
                {
                    for (int i1 = 0; i1 < 5; i1++)
                    {
                        if (parque[1, i1] == false)
                        {

                            Console.Write("Parque : fila 2 lugar : {0}", i1 + 1);
                            parque[1, i1] = true;
                            estacionado = true;
                            break;
                            
                        }
                        else if (i1==4)
                        {
                            for (int i2 = 0; i2 < 5; i2++)
                            {
                                if (parque[2,i2]==false)
                                {
                                    Console.Write("Parque : fila 3 lugar : {0}", i2 + 1);
                                    parque[2, i2] = true;
                                    estacionado = true;
                                    break;
                                }
                                else if (i2==4)
                                {
                                    Console.Write("Parque Cheio");
                                }
                            }
                            if (estacionado == true)
                            {
                                break;
                            }
                        }
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
    
}
