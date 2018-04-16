using System;
using System.Globalization;

namespace _13._1000daysAfterBirth
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime dt = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
            Console.WriteLine(dt.AddDays(999).ToString("dd-MM-yyyy"));
            
        }
    }
}
