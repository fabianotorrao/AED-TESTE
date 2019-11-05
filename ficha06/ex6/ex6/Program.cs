using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {// dado 12 registos de pluviosidade o programa de ordenar os registos e listar os nomes dos meses
            string[] meses = new string[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            double[] pluviosidade = new double[12];
            string[] meses_listados = new string[12];
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(10, 10);
                Console.Write("Insira o valor do {0}º mês -->", i + 1);
                pluviosidade[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            double[] pluviosidade_ordenada = new double[12];
            Array.Copy(pluviosidade, pluviosidade_ordenada,12);
            Array.Sort(pluviosidade_ordenada);
            Console.SetCursorPosition(10, 10);
            Console.Write("Pluviosidade ordenada :");
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(15, 11 + i);
                int indice_mes=Receber_mes(i,pluviosidade,pluviosidade_ordenada,meses_listados,meses);
                Console.Write(pluviosidade_ordenada[i]+" Mês : "+meses[indice_mes]);
                meses_listados[i] = meses[indice_mes];
            }
            Console.ReadKey();

        }
        public static int Receber_mes(int i, double[] pluviosidade, double[] pluviosidade_ordenada,string[] meses_listados,string[] meses)
        {
            int index=0;
            for (int i1 = 0; i1 < pluviosidade.Length; i1++)
            {
                if (pluviosidade[i1] == pluviosidade_ordenada[i]&&!meses_listados.Contains(meses[i1]))
                {
                    index = i1;
                    break;
                }
                    
            }
            return index;
        }
    
    }
    
}
