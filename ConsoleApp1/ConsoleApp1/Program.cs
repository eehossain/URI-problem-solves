using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            double a = 3.5;
            double b = 7.5;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = ((x * a) + (y * b)) / (a + b);
            Console.WriteLine("MEDIA = {0}",z.ToString(".00000"));
        }
    }
}
