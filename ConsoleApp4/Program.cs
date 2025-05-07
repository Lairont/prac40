using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
            delegate double AverageDelegate(int m, int n);

            static void Main(string[] args)
            {
                IOAverage();
                IOAverage();
                IOAverage();
            }
            static void IOAverage()
            {
            AverageDelegate averageDelegate = Average;

                Console.Write("Первое число = ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Второе число = ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"Среднее арифметическое чисел от {m} до {n}: {averageDelegate.Invoke(m, n)}\n");
                Console.Read();
            }
    public static double Average(int m, int n)
        {
            return (m + n) / 2.0;
        }
    }
}
