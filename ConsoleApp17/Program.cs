using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        delegate double AverageDelegate(int m, int n);

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n = int.Parse(Console.ReadLine());
            AverageDelegate del = Average;

            Console.WriteLine($"Среднее арифметическое от {m} до {n}: {del(m, n)}");

            Console.Read();
        }
        static public double Average(int m, int n)
        {
            double sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }
    }
}
