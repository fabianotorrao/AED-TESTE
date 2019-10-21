using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //dado um numero em decimal o programa deve devolver o seu correspondente em romano
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Int16 numero = 0;
            do
            {
                Console.SetCursorPosition(15, 10);
                Console.Write("Insira um numero a converter --> ");
                numero = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (numero > 0)
                {
                    var n_rom = conversion(numero);
                    Console.SetCursorPosition(15, 10);
                    Console.Write("Numero decimal : {0}", numero);
                    Console.SetCursorPosition(15, 12);
                    Console.Write("Numero romano : {0}", n_rom);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (numero!=0);
            

        }
        public static string conversion (int number)
        {

            if (number >= 900)
            {
                return "CM" + conversion(number - 900);
            }
            else if (number >= 500)
            {
                return "D" + conversion(number - 500);
            }
            else if (number >= 400)
            {
                return "CD" + conversion(number - 400);
            }
            else if (number >= 100)
            {
                return "C" + conversion(number - 100);
            }
            else if (number >= 90)
            {
                return "XC" + conversion(number - 90);
            }
            else if (number >= 50)
            {
                return "L" + conversion(number - 50);
            }
            else if (number >= 40)
            {
                return "XL" + conversion(number - 40);
            }
            else if (number >= 10)
            {
                return "X" + conversion(number - 10);
            }
            else if (number >= 9)
            {
                return "IX" + conversion(number - 9);
            }
            else if (number >= 5)
            {
                return "V" + conversion(number - 5);
            }
            else if (number >= 4)
            {
                return "IV" + conversion(number - 4);
            }
            else if (number >= 1)
            {
                return "I" + conversion(number - 1);
            }
            else
            {
                return "";
            }
            
        }
    }
}
