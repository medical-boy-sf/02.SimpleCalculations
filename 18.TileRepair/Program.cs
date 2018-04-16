using System;
/*
 * •N – дължината на страна от площадката в интервала [1...100]
•	W – широчината на една плочка в интервала [0.1...10.00]
•	L – дължината на една плочка в интервала [0.1...10.00]
•	М – широчината на пейката в интервала [0...10]
•	О – дължината на пейката в интервала [0...10]

 * */
namespace _18.TileRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double areaSquare = n * n;
            double areaTile = w * l;
            double areaBench = m * o;
            double filledArea = areaSquare - areaBench;
            double neededTiles = filledArea / areaTile;
            double timeNeeded = neededTiles * 0.2;
            Console.WriteLine($"{neededTiles:F2}");
            Console.WriteLine($"{timeNeeded:F2}");

        }
    }
}
