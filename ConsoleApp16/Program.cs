using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        delegate double MathOperation(double a, double b);

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            MathOperation del;
            del = Sum; 
            Console.WriteLine($"Сумма: {del(a, b)}");

            del = Subtract; 
            Console.WriteLine($"Разность: {del(a, b)}");

            del = Mult; 
            Console.WriteLine($"Произведение: {del(a, b)}");

            del = Div; 
            Console.WriteLine($"Деление: {del(a, b)}");

            Console.Read();
        }
        static public double Sum(double a, double b) => a + b;
        static public double Subtract(double a, double b) => a - b;
        static public double Mult(double a, double b) => a * b;
        static public double Div(double a, double b) => a / b;
    }
}
