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
        {
            //dada os três lados de um triangulo classificar esse mesmo triangulo
            var lados = new List<decimal>();
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Insira o valor do {0}º lado -->", i);
                lados.Add(Convert.ToDecimal(Console.ReadLine()));
                Console.Clear();
            }
            if (lados[0] == lados[1] && lados[2] == lados[0])
            {
                Console.Write("O triangulo é equilátero");
            }
            else
            {
                if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2])
                {
                    Console.Write("O triangulo é isósceles");
                }
                else
                {
                    if (lados[0] != lados[1] && lados[0] != lados[2] && lados[1] != lados[2])
                    {
                        Console.Write("O triangulo é escaleno ");
                    }

                }
                
                

            
            }
            Console.ReadKey();
        }
        
    }
}
