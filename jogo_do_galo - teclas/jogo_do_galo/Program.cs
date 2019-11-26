using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_do_galo
{
    class Program
    {
        static void Main(string[] args)
        {
            char novamente= 'S';
            while (novamente=='S')
            {


                int round = 0;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                /*o programa deve ler o nome dos jogares e agir como jogo do galo fazendo todas as verficações e terminando num empate ou vitória*/
                string[] players = new string[2];
                string[,] tabuleiro = new string[3, 3];
                char stat = 'N';
                int jg = 0;
                ler_players(players);
                do
                {
                    bool val = false;
                    while (val == false)
                    {
                        val = jogada(jg, tabuleiro, players);
                    }
                    listar(tabuleiro);
                    jg = variar_player(jg);

                    round = vencedor_verificacao(tabuleiro, players, round);
                    if (round == -3)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 10);
                        Console.Write("Parabéns, {0} Ganhou", players[1]);
                        Console.ReadKey();
                        stat = 'V';
                    }
                    else if (round == -2)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 10);
                        Console.Write("Parabéns, {0} Ganhou", players[0]);
                        Console.ReadKey();
                        stat = 'V';

                    }
                    else if (round == -1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 10);
                        Console.Write("Empate! Jogue novamente", players[0]);
                        Console.ReadKey();
                        stat = 'V';

                    }


                } while (stat == 'N');
                Console.Clear();
                Console.SetCursorPosition(10, 10);
                Console.Write("Deseja jogar novamente? S/N -->");
                novamente = Convert.ToChar(Console.ReadLine().ToUpper());
            }

        }
        public static int vencedor_verificacao(string [,] tabuleiro,string [] players,int round)
        {
            if (round<=9)
            {
                round++;
                if ((tabuleiro[0, 0] != null))
                {
                    if ((tabuleiro[0, 0].Equals(tabuleiro[0, 1]) && tabuleiro[0, 0].Equals(tabuleiro[0, 2])) || (tabuleiro[0, 0].Equals(tabuleiro[1, 1]) && tabuleiro[0, 0].Equals(tabuleiro[2, 2])) || (tabuleiro[0, 0].Equals(tabuleiro[1, 0]) && tabuleiro[0, 0].Equals(tabuleiro[2, 0])))
                    {
                        if (tabuleiro[0, 0] == "X")
                            return -3;
                        else
                            return -2;
                    }
                }
                if (tabuleiro[2, 0] != null)
                {
                    if ((tabuleiro[0, 2].Equals(tabuleiro[1, 1]) && tabuleiro[0, 2].Equals(tabuleiro[2, 0])) || (tabuleiro[2, 0].Equals(tabuleiro[2, 1]) && tabuleiro[2, 0].Equals(tabuleiro[2, 2])))
                    {
                        if (tabuleiro[2, 0] == "X")
                            return -3;
                        else
                            return -2;
                    }
                }
                if(tabuleiro[0,2]!=null)
                {
                    if (tabuleiro[0,2].Equals(tabuleiro[1,2])&& tabuleiro[0, 2].Equals(tabuleiro[2,2]))
                    {
                        if (tabuleiro[0,2] == "X")
                            return -3;
                        else
                            return -2;
                    }
                }
                if(tabuleiro[1,1]!=null)
                {
                    if ((tabuleiro[1,1].Equals(tabuleiro[0,1])&&tabuleiro[1,1].Equals(tabuleiro[2,1]))||(tabuleiro[1,1].Equals(tabuleiro[1,0])&&tabuleiro[1,1].Equals(tabuleiro[1,2])))
                    {
                        if (tabuleiro[1,1] == "X")
                            return -3;
                        else
                            return -2;
                    }
                }
            }
            
            
            return round;


        }
        public static void listar(string[,]tabuleiro)
        {
            Console.Clear();
            Console.SetCursorPosition(69, 15);
            Console.Write("___________");
            Console.SetCursorPosition(69,17);
            Console.Write("___________");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(72, 14 + i);
                Console.Write("|");
                Console.SetCursorPosition(76, 14 + i);
                Console.Write("|");
            }
            int x = 71, y = 14;
            for (int i = 0; i < 3; i++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(tabuleiro[i, i1]);
                    x = x + 3;
                }
                y = y + 2;
                x = 71;
            }
            
        }
        public static bool jogada(int i, string[,] tabuleiro, string[] players)
        {
            Console.SetCursorPosition(10, 10);
            Console.Write("Insira as coordenadas (1,1 até 3,3) " + players[i] + "(X Y) : ");
            var coord = Console.ReadLine().Split(' ');
            if (Convert.ToInt16(coord[0])>3||Convert.ToInt16(coord[1])>3)
            {
                Console.Clear();
                Console.SetCursorPosition(10, 10);
                Console.Write("Coordenada inválida! Tente novamente");
                Console.ReadKey();
                return false;
            }
            Console.Clear();
            if (tabuleiro[Convert.ToInt16(coord[0]) - 1, Convert.ToInt16(coord[1]) - 1] is null)
            {
                if (i == 0)
                    tabuleiro[Convert.ToInt16(coord[0]) - 1, Convert.ToInt16(coord[1]) - 1] = "O";
                else
                    tabuleiro[Convert.ToInt16(coord[0]) - 1, Convert.ToInt16(coord[1]) - 1] = "X";
                return true;
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(10, 10);
                Console.Write("Coordenada ocupada! Tente novamente");
                Console.ReadKey();
                return false;
            }
            
        }






        public static int variar_player(int jg)
        {
            if (jg == 0)
                jg++;
            else
                jg = 0;
            return jg;
        }
        public static void ler_players(string[] players)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(15, 15);
                Console.Write("Nome Player {0} : ", i + 1);
                players[i] = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
