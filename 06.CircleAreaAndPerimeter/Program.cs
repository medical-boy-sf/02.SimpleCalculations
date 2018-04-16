using System;

namespace _06.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
