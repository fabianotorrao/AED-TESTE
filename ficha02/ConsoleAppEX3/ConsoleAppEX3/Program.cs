using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEX3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //dada uma lista de 10 numeros devolve o numero de pares, impares e o maximo
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            int max = 0, pares=0, imp=0, numero;
            for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(40, 10);
                Console.Write("Introduza o {0}º numero --> ",i);
                numero = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if ((numero%2)==0)
                {
                    pares++;
                }
                else
                {
                    imp++;
                }
                if (numero>max)
                {
                    max = numero;
                }
            }
            Console.SetCursorPosition(40, 10);
            Console.Write("Pares : {0} Ímpares : {1} Máximo : {2}",pares,imp,max);
            Console.ReadKey();
        }
    }
}
