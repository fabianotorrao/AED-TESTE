using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ex2
{
    class Program
    {
        //dado um ficheiro de temperaturas e com "timestamp" o programa deve listar os dados
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\fabia\Desktop\esmad\AED\ficha08\ex1\ex1\bin\Debug\temperatura.txt";
            if (!File.Exists(filepath))
            {
                Console.Write("Caminho inválido/ficheiro inexistente");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                int y = 12;
                Console.SetCursorPosition(15, 10);
                Console.Write("Data:");
                Console.SetCursorPosition(35, 10);
                Console.Write("Hora");
                Console.SetCursorPosition(55, 10);
                Console.Write("Temperatura");
                Console.SetCursorPosition(14, 11);
                Console.Write("-------------------------------------------------------");
                var sr = File.ReadAllLines(filepath);
                foreach (var line in sr)
                {
                    string[] content=line.Split(' ');
                    Console.SetCursorPosition(15, y);
                    Console.Write(content[0]);
                    Console.SetCursorPosition(35, y);
                    Console.Write(content[1]);
                    Console.SetCursorPosition(55, y);
                    Console.Write(content[2]);
                    y++;
                }
                Console.ReadKey();
            }
        }
    }
}
