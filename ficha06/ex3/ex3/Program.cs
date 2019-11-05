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
            //dado 10 registos de pontuações de 10 participantes e os seus nomes o programa deve copiar os registos positivos e imprimir
            double[] pontuacoes = new double[10];
            string[] nomes = new string[10];
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                
                    Console.SetCursorPosition(10, 15);
                    Console.Write("Insira o nome do {0}º participante : ",i+1);
                    nomes[i] = Console.ReadLine();
                do
                {
                    Console.SetCursorPosition(10, 15);
                    Console.Write("Insira a pontuação do {0}º participante --> ", i + 1);
                    pontuacoes[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                } while (pontuacoes[i] < 0 || pontuacoes[i] > 20);
            }
            double[] positivas = new double[0];
            string[] nomes_positivo = new string[0];
            for (int i = 0; i < pontuacoes.Length; i++)
            {
                if (pontuacoes[i] >= 10)
                {
                    Array.Resize(ref positivas, positivas.Length + 1);
                    Array.Resize(ref nomes_positivo, nomes_positivo.Length+1);
                    positivas[positivas.Length - 1] = pontuacoes[i];
                    nomes_positivo[nomes_positivo.Length - 1] = nomes[i];

                }
            }     
            
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.Write("Pontuações positivas : ");
            for (int i = 0; i < positivas.Length; i++)
            {
                Console.SetCursorPosition(13, 11 + i);
                Console.Write(nomes_positivo[i] + " " + positivas[i]);
            }
            Console.ReadKey();
        }
    }
}
