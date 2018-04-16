using System;

namespace _08.TriangleArea
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = Math.Round(a * h / 2, 2);

            Console.WriteLine($"Triangle area = {area}");
        }
    }
}
