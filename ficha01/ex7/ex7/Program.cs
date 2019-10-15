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
            //dado um genero e a sua altura o programa devolve o peso ideal do individuo

            char genero;
            int k;
            double altura;
            Console.Write("Intorduza o seu genero (M/F) --> ");
            genero=Convert.ToChar(Console.ReadLine().ToUpper());
            if (genero=='M')
            {
                k = 4;   
            }
            else
            {
                k = 2;
            }
            Console.Clear();
            Console.Write("Insira a altura em cm --> ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double peso_ideal = (altura - 100) - (altura - 150) / k;
            Console.Write("O peso ideal será de {0} Kg",Math.Round(peso_ideal,2));
            Console.ReadKey();
            

        }
    }
}
