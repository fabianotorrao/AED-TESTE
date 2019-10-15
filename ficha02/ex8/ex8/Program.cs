using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            // dado um numero o programa deve devolver 1 se o numero for perfeito e 0 se não for

            Console.Write("Introduza um número inteiro --> ");
            int numero = Convert.ToInt16(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i < numero-1; i++)
            {
                if ((numero%i)==0)
                {
                    soma =soma+ i;

                }
            }
            Console.Clear();
            if (soma==numero)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
            Console.ReadKey();

        }
    }
}
