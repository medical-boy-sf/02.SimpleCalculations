﻿using System;

namespace _01.SquareArea
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine($"Square = {area}");
        }
    }
}
