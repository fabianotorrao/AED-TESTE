using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //o programa deve gerar aleatóreamente uma chave completa do euromilhoes e no final perguntar se deseja criar novamente
            char op;
            
            do
            {
                int[] numeros = new int[5];
                int[] estrelas = new int[2];
                Console.Clear();
                gerar_chave(numeros,51,5);
                gerar_chave(estrelas,12,2);
                Console.SetCursorPosition(5, 15);
                Console.Write("Chave : ");
                listar(numeros);
                Console.SetCursorPosition(5, 16);
                Console.Write("Estrelas : ");
                listar(estrelas);
                Console.ReadKey();
                Console.Clear();
                Console.SetCursorPosition(15, 15);
                Console.Write("Deseja gerar uma nova chave S/N --> ");
                op =Convert.ToChar(Console.ReadLine().ToUpper());
            } while (op!='N');
        }
        public static void listar(int[]numeros)
        {
            foreach (var item in numeros)
            {
                Console.Write(item + " ");
            }
            
        }
        public static void gerar_chave(int[]numeros,int lim,int n_lim)
        {
            Random rnd = new Random();
            int ct = 0;
            while (ct!=n_lim)
            {
                int n = rnd.Next(0, lim);
                if(!numeros.Contains(n))
                {
                    numeros[ct] = n;
                    ct++;
                }
            }
            Array.Sort(numeros);   
            
        }
    }
}
