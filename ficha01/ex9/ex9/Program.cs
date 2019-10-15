using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        //dado numero o programa devolve o dia da semana correspondente

        static void Main(string[] args)
        {
            Console.Write("Introduza um número --> ");
            double dia = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            switch (dia)
            {
                case 1: Console.Write("1 - Domingo");
                    break;
                case 2: Console.Write("2 - Segunda - Feira");
                    break;
                case 3: Console.Write("3 - Terça - Feira");
                    break;
                case 4: Console.Write("4 - Quarta - Feira");
                    break;
                case 5: Console.Write("5 - Quinta - Feira");
                    break;
                case 6: Console.Write("6 - Sexta - Feira ");
                    break;
                case 7: Console.Write("7 - Sábado");
                    break;

                default:Console.Write("Número inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
