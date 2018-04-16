using System;

namespace _17.GroceryMarket
{
    class Program
    {
        static void Main()
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double quantityVegetables = double.Parse(Console.ReadLine());
            double quantityFruits = double.Parse(Console.ReadLine());

            double totalPriceEur = (priceFruits * quantityFruits + priceVegetables * quantityVegetables) / 1.94;

            Console.WriteLine($"{Math.Round(totalPriceEur, 2):F2}");

        }
    }
}
