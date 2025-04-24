using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        delegate void Message(); // Шаг 1: объявляется делегат

        static void Main(string[] args)
        {
            Message message; // Шаг 2
            //message = Hello; // Шаг 3
            //message(); // Шаг 4

            //Message message1 = Goodbye;
            //message1();

            int hour = DateTime.Now.Hour;

            if (hour < 12)
                message = Hello;
            else
                message = Goodbye;
            message(); 

            Console.Read();
        }

        static public void Hello() => Console.WriteLine("Hello");

        static public void Goodbye() => Console.WriteLine("Goodbye");
    }
}
