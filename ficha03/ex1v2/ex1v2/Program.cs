using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex1v2
{
    class Program
    {
        static void Main(string[] args)
        {
            // o programa devolve a frequencia cardiaca máxima dado o genero e a idade e gera um valor de frequencia cardiaca
            // o qual classifica o esforço cardiaco
            Console.Title = ("Simulador de esforço cardiaco");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(10, 2);
            Console.Write("Género(M/F) --> ");
            char gen = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.SetCursorPosition(30, 2);
            Console.Write("Idade : ");
            int idade = Convert.ToInt16(Console.ReadLine());
            double fcm = 0;
            Console.SetCursorPosition(50, 2);
            if (gen == 'F')
            {
                fcm = 226 - idade;

            }
            else
            {
                fcm = 220 - idade;
            }
            Console.WriteLine("FCM = {0} bpm", fcm);

            //adição v2
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(10, 2);
                Console.Write("Género(M/F) --> {0}",gen);
                Console.SetCursorPosition(30, 2);
                Console.Write("Idade : {0}",idade);
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("FCM = {0} bpm", fcm);
                Random rnd = new Random();
                int bpm = rnd.Next(60, Convert.ToInt16(fcm + 1));
                Console.SetCursorPosition(30, 5);
                Console.Write("Frequencia cardiaca --> {0}", bpm);
                Console.SetCursorPosition(35, 7);
                if ((fcm * 0.6) >= bpm)
                {
                    Console.Write("Atividade moderada");
                }
                else if ((fcm * 0.7) >= bpm)
                {
                    Console.Write("Treino de resistência");
                }
                else if ((fcm * 0.80) >= bpm)
                {
                    Console.Write("Nível aeróbico");
                }
                else if ((fcm * 0.90) >= bpm)
                {
                    Console.Write("Nível anaeróbico");
                }
                else
                {
                    Console.Write("Red zone");
                }
                Thread.Sleep(1000);
            }
            


        }
    }
}
