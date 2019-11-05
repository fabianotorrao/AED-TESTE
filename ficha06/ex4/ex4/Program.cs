using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //dado 12 valores de faturação mensal o programa deve devolver o mes com o máximo, minimo e faturação média
            double[] faturacao = new double[12];
            string[] meses=new string [12] {"Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(10, 10);
                Console.Write("Insira o valor do {0}º mês -->", i + 1);
                faturacao[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            Console.SetCursorPosition(15, 15);
            Console.Write("Maximo de faturacao : " + meses[Array.IndexOf(faturacao,faturacao.Max())]);
            Console.SetCursorPosition(15, 16);
            Console.Write("Mínimo de faturacao : " + meses[Array.IndexOf(faturacao, faturacao.Min())]);
            Console.SetCursorPosition(15, 17);
            Console.Write("Média mensal : " + faturacao.Average().ToString("##.##"));
            Console.ReadKey();
        }
    }
}
