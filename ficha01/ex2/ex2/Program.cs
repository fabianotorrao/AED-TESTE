using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        //dado um valor em Cº o programa devolve o correspondente em fahrenheit
        static void Main(string[] args)
        {
            Console.Write("Insira o valor em º Celsius --> ");
            double temp_celc = Convert.ToDouble(Console.ReadLine());
            double temp_far = 1.8 * temp_celc + 32;
            Console.Clear();
            Console.Write("A temperatura {0} ºC corresponde a {1} em Fahrenheit ",temp_celc,temp_far);
            Console.ReadKey();
        }
    }
}
