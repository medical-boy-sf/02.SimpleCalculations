using System;

namespace _02.InchesToCentimeters
{
    class Program
    {
        static void Main()
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine($"centimeters = {centimeters}");
        }
    }
}
