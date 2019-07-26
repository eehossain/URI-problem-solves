using System;

namespace Extremely_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;

            Console.WriteLine("X = {0}",z);
        }
    }
}
