using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //dado um user name o programa deve gerar uma password bem como informar o utilizar se o user name está correto
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string user;
            do
            {

            
            Console.Clear();
            Console.SetCursorPosition(30, 10);

            Console.Write("Insira o utilizador --> ");
            user = Console.ReadLine();
            Console.Clear();
            string [] user_check = user.Split(' ');
            if (user_check.Count()>1||user==" "||user=="")
            {
                    Console.SetCursorPosition(30, 10);
                Console.Write("Atenção ! Username inválido");
                Console.ReadKey();
            }
                else { break; }
            } while (true);
            string password="";
            for (int i = 1; i < user.Length ; i+=2)
            {
                Random rnd = new Random();
                int num = rnd.Next(1,10);
                password =password+ user[i] + num.ToString();
            }
            password = password + user.Length.ToString();
            Console.SetCursorPosition(30, 10);
            Console.Write("Username : {0}",user);
            Console.SetCursorPosition(30, 12);
            Console.Write("Password : {0}", password);
            Console.ReadKey();

        }
    }
}
