using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        // dado um número o programa pretende verificar se é um numeros par ou ímpar
        static void Main(string[] args)
        {
            Console.Write("Introduza um número inteiro --> ");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            int resto = numero % 2;
            if (resto == 0)
            {
                Console.WriteLine("o número {0} é par", numero);
            }
            else
            {
                Console.WriteLine("o número {0} é ímpar", numero);
            }
            Console.ReadKey();
            
        }
    }
}
