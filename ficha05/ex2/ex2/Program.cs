using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //dado uma string o programa deve aplicar a cifra de Cesar de modo a codificar o texto
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(15, 10);
            Console.Write("Insira a sua string : ");
            string text = Console.ReadLine();
            Console.SetCursorPosition(15, 12);
            Console.Write("Insira a chave --> ");
            int chave = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            string texto_final = codificacao(text,chave);
            Console.SetCursorPosition(15, 10);
            Console.Write("Texto inicial : {0}", text);
            Console.SetCursorPosition(15, 12);
            Console.Write("Texto codificado : {0}", texto_final);
            Console.ReadLine();

        }
        public static string codificacao (string text,int chave)
        {

            string texto_final = "";
            foreach (var ch in text)
            {
                int code = Convert.ToInt16(ch);
                code += chave;
                texto_final +=Convert.ToChar(code);
                
            }
            return texto_final;
        }
    }
}
