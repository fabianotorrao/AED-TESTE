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
            // o programa devolve a frequencia cardiaca máxima dado o genero e a idade
            Console.Title=("Simulador de esforço cardiaco");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(40, 15);
            Console.Write("Género(M/F) --> ");
            char gen = Convert.ToChar( Console.ReadLine().ToUpper());
            Console.SetCursorPosition(40, 20);
            Console.Write("Idade : ");
            int idade = Convert.ToInt16(Console.ReadLine());
            double fcm = 0;
            Console.SetCursorPosition(50, 18);
            if (gen=='F')
            {
                fcm = 226 - idade;
                    
            }
            else
            {
                fcm=220 - idade;
            }
            Console.WriteLine("FCM = {0} bpm", fcm);
            Console.ReadKey();
        }
    }
}
