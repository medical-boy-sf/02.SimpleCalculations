using System;
namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main()
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = Math.Round(radians * 180 / Math.PI, 0);

            Console.WriteLine(degrees);
        }
    }
}
