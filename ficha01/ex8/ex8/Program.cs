using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        //dado a altura em m e o peso em kg o programa devolve o grau de obesidade de acordo com o seu IMC
        static void Main(string[] args)
        {
            Console.Write("Introduza o peso (KG) --> ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduza a altura (M) -->");
            double altura = Convert.ToDouble(Console.ReadLine());
            double imc = peso / Math.Pow(altura, 2);
            Console.Clear();
            Console.WriteLine("IMC = {0}", Math.Round(imc, 2));

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
               
            }
            else if (imc > 24.9 && imc<=29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc>29.9&&imc<=34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc>34.9&&imc<=39.9)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else
            {
                Console.WriteLine("Obesidade Grau III");
            }

            Console.ReadKey();
            
        }
    }
}
