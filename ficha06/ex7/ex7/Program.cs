using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Contabilidade";
            //dado a produção mensal de uma empresa o programa deve devolver a prod mensal, o total somado de todos os meses, e o mes em que a producao alcança metade da total
            double[] producao = new double[12];
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            string[] meses = new string[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(10, 10);
                Console.Write("Insira o valor de produção do {0}º mês -->", i + 1);
                producao[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

            }
            listar(meses, producao);
            Console.ReadLine();
        }
       public static void listar(string[] meses, double[] producao)
        {
            Console.SetCursorPosition(30, 7);
            Console.Write("Relatório anual");
            double somatorio = 0;
            Double prod_total = producao.Sum();
            Console.SetCursorPosition(10, 10);
            Console.Write("MÊS");
            Console.SetCursorPosition(28, 10);
            Console.Write("Valor da prod.");
            Console.SetCursorPosition(50, 10);
            Console.Write("Valor acumulado");
            int mes_metade = 0;
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(8, 12 + i);
                Console.Write(meses[i]);
                Console.SetCursorPosition(35, 12 + i);
                Console.Write(producao[i]);
                Console.SetCursorPosition(57, 12 + i);
                somatorio +=producao[i];
                Console.Write(somatorio);
            }
            double soma_mes = 0;
            for (int i = 0; i < 12; i++)
            {
                soma_mes += producao[i];
                if (soma_mes >= (prod_total / 2))
                {
                    mes_metade = i;
                    break;
                }
            }
            Console.SetCursorPosition(8, 24);
            Console.Write("Total: ");
            Console.SetCursorPosition(35, 24);
            Console.Write(somatorio);
            Console.SetCursorPosition(57,24);
            Console.Write(somatorio);
            Console.SetCursorPosition(8, 26);
            Console.Write("Mês em que se alcançou metade da produção anual : {0}", meses[mes_metade]);


        }
    }
}
