using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        // calcular uma medida dada em polegas e devolver em centimetros e milimetros
        static void Main(string[] args)
        {
            Console.Write("Insira a medida em polegadas --> ");
            double med_polegadas=Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double med_mm = med_polegadas * 25.4;
            double med_cm = med_mm / 10;
            Console.WriteLine("mm = {0}, cm = {1}",med_mm,med_cm);
            Console.ReadKey();
        }
    }
}
