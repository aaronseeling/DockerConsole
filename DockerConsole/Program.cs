using System;

namespace DockerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            double i = 0.0;
            while (1 == 1)
            {
                sum += 4.0 * Math.Pow(-1.0, i) / (2.0 * i + 1);
                if (i % 10000000 == 0)
                    Console.WriteLine("{0}      {1}", DateTime.Now, sum);
                i++;
            }
        }
    }
}
