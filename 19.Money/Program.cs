using System;
/*
    На първия ред – броят биткойни. Цяло число в интервала [0…20]
	На втория ред – броят китайски юана. Реално число в интервала [0.00… 50 000.00]
	На третия ред – комисионната. Реално число в интервала [0.00 ... 5.00]

 */
namespace _19.Money
{
    class Program
    {
        static void Main()
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double chineseYuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double levas = bitcoins * 1168 + chineseYuan * 0.15 * 1.76;
            double euros = levas / 1.95;
            double total = euros - euros * commission * 0.01;

            Console.WriteLine($"{total:F2}");
        }
    }
}
