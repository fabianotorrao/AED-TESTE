using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        //dado um numero em segundos o programa devolve o respetivo valor em horas, minutos e segundos
        static void Main(string[] args)
        {
            Console.Write("Introduza o valor em segundos : ");
            double segundos = Convert.ToDouble(Console.ReadLine());
            double horas_decimal = (segundos / 3600);
            int horas =Convert.ToInt16( Math.Truncate(horas_decimal));
            horas_decimal -= horas;
            double minutos_decimal = horas_decimal * 60;
            int minutos = Convert.ToInt16(Math.Truncate(minutos_decimal));
            minutos_decimal -= minutos;
            double segundos_decimal = minutos_decimal * 60;
            int segundos_final = Convert.ToInt16(Math.Truncate(segundos_decimal));
            Console.Clear();
            Console.WriteLine("{0} segundos = {1} hora/s, {2} minutos e {3} segundos",segundos,horas,minutos,segundos_final);
            Console.ReadKey();
        }
    }
}
