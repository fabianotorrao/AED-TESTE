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
            //dado 10 registos de pontuações de 10 participantes o programa deve copiar os registos positivos e imprimir
            double[] pontuacoes = new double[10];
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.SetCursorPosition(10, 15);
                    Console.Write("Insira a pontuação do {0}º participante --> ", i + 1);

                    pontuacoes[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                } while (pontuacoes[i]<0||pontuacoes[i]>20);    
            }
            double[] positivas = new double[0];
            foreach (var registo in pontuacoes)
            {
                if (registo>=10)
                {
                    Array.Resize(ref positivas, positivas.Length+1);
                    positivas[positivas.Length - 1] = registo;
                    
                }
            }
            Console.Clear();
            Console.SetCursorPosition(10, 12);
            Console.Write("Pontuações positivas : ");
            foreach (var registo in positivas)
            {
                Console.Write(registo + " ");
            }
            Console.ReadKey();
        }
    }
}
