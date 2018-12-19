using System;

namespace PIDock
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 0.0;
            double sum = 0.0;
            while (1 == 1)
            {
                sum += 4.0 * Math.Pow(-1.0, i) / (2.0 * i + 1.0);
                if (i % 100000000 == 0)
                    Console.WriteLine("{0}    {1}", i, sum);
                i++;
            }
        }
    }
}
