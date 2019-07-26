using System;

namespace Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = 3.14159 * a * a;


            Console.WriteLine("A={0}",b.ToString("0.0000"));
        }
    }
}
