using System;

namespace Simple_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            z = x * y;

            Console.WriteLine("PROD = {0}",z);
        }
    }
}
