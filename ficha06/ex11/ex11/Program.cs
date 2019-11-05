using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {

        static void Main(string[] args)
        {
            // seguido de um menu o programa deve gerir as senhas de uma fila. tirar ticket, atender e ver o estado da fila (quantas pessaos)
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int opcao = 0;
            int ct = 0;
            Queue<int> senhas = new Queue<int>(20);
            do
            {
                Console.SetCursorPosition(20, 9);
                Console.Write("********************************");
                Console.SetCursorPosition(20, 10);
                Console.Write("*       1 - Tirar Ticket       *");
                Console.SetCursorPosition(20, 11);
                Console.Write("*       2 - Atendimento        *");
                Console.SetCursorPosition(20, 12);
                Console.Write("* 3 - Estado da fila de espera *");
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
                    case 1:ct++;
                        tirarticket(senhas,ct);
                        break;
                    case 2:atender(senhas);
                        break;
                    case 3:estado(senhas);
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }
        public static void estado(Queue<int>senhas)
        {
            int n = senhas.Count();
            Console.SetCursorPosition(15, 15);
            if (n>0)
            {
                
                Console.Write("Lugares da fila: {0}", n);
            }
            else
            {
                Console.Write("Fila vazia");
            }
            Console.ReadKey();
            Console.Clear();

        }

        public static void atender(Queue<int>senhas)
        {
            int n = senhas.Count();
            Console.SetCursorPosition(15, 15);
            if(n>0)
            {
                Console.Write("Numero: {0} dirija-se ao balção", senhas.Dequeue());
            }
            else
            {
                Console.Write("Sem pessoas espera");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void tirarticket(Queue<int> senhas,int ct)
        {
            int n=senhas.Count();
            Console.SetCursorPosition(15, 15);
            if (n<20)
            {
                ;
                senhas.Enqueue(ct);
                Console.Write("Numero do seu ticket : {0}", ct);
            }
            else
            {
                Console.Write("Fila cheia aguarde que outros sejam atendidos");
            }
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}
