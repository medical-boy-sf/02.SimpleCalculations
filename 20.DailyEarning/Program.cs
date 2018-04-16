using System;

namespace _20.DailyEarning
{
    class Program
    {
        static void Main()
        {
            double workingDays = double.Parse(Console.ReadLine());
            double earnedMoneyPerDay = double.Parse(Console.ReadLine());
            double currencyUSDtoBGN = double.Parse(Console.ReadLine());
            double yearlyEarning = workingDays * earnedMoneyPerDay * 12 + workingDays * earnedMoneyPerDay * 2.5;
            double TotalWithtaxesBGN = yearlyEarning -  yearlyEarning * 0.25;
            double TotalWithtaxesUSD = TotalWithtaxesBGN * currencyUSDtoBGN;
            double meanEarningPerDay = TotalWithtaxesUSD / 365;
            Console.WriteLine($"{meanEarningPerDay:F2}");

        }
    }
}
