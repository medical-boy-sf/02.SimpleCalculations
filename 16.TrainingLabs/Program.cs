using System;

namespace _16.TrainingLabs
{
    class Program
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine()) * 100;
            double w = double.Parse(Console.ReadLine()) * 100;
            double rows = Math.Truncate(h / 120);
            double desks = Math.Truncate((w - 100) / 70);
            double seats = rows * desks - 3;
            Console.WriteLine(seats);

        }
    }
}
