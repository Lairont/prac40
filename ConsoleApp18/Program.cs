using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        delegate int SumDelegate(int m, int n);
        static void Main(string[] args)
        {
            SumDelegate del = Sum;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите первое число: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Сумма чисел от {m} до {n}: {del(m, n)}");
            }
        }
        static int Sum(int m, int n) => (n - m + 1) * (m + n) / 2;


    }
}
