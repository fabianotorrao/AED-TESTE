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
            // dado um numero inteiro o programa deve devolver os n primeiros termos da sequencia de fibonacci

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.Write("Introduza o numero de termos que vai desejar ver --> ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(20, 9);
            Console.Write("Os {0} primeiros termos",n);
            int resultado = 0, ultimo = 1,pnultimo=0 ;
            if (n <= 1)

                Console.WriteLine("1");
            else
            {
                
                for (int i = 1; i <= n; i++)
                {
                    if (i <=2)
                    {
                         Console.Write(" - "+resultado);
                        resultado++;
                    }
                    else
                    {
                        
                        resultado=(ultimo)+pnultimo;
                        Console.Write(" - "+resultado);
                        
                        
                            pnultimo = ultimo;
                            ultimo = resultado;
                        
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
