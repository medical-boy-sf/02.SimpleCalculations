﻿using System;
namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main()
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine(fahrenheit);
        }
    }
}
