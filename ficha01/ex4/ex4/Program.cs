using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        // dado a altura em metros e o peso em kilogramos o programa devolve o respetivo IMC
        static void Main(string[] args)
        {
            Console.Write("Introduza o peso (KG) --> ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduza a altura (M) -->");
            double altura = Convert.ToDouble(Console.ReadLine());
            double imc = peso / Math.Pow(altura,2);
            Console.Clear();
            Console.WriteLine("IMC = {0}", Math.Round(imc,2));
            Console.ReadKey();
        }
    }
}
