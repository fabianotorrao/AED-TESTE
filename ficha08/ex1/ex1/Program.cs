using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ex1
{
    class Program
    {
        // o programa enquanto aberto deve criar/adicionar a um ficheiro valores aleatórios com o timestamp
        static void Main(string[] args)
        {
            string path = "temperatura.txt";
            if (!File.Exists(path))
            {
                StreamWriter cr = File.CreateText(path);
                cr.Close();

                
            }
            
            gerar_dados(path);
        }
        public static System.IO.StreamWriter gerar_dados(string path)
        {
            
            do
            {
                StreamWriter sw = File.AppendText(path);
                Random rnd = new Random();
                int n = rnd.Next(10, 26);
                string st = (DateTime.Now.ToString() + " " + n);
                sw.WriteLine(st);
                sw.Close();
                Thread.Sleep(1000);
            } while (true);
            
        }
    }
}
    

