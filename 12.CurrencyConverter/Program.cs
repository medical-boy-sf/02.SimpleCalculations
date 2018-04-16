using System;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main()
        {
            double val = double.Parse(Console.ReadLine());
            string currency = Console.ReadLine().ToUpper();
            string convertedCurrency = Console.ReadLine().ToUpper();
            double total = 0;
            double bgn = 1;
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            if (currency == "BGN")
            {
                switch (convertedCurrency)
                {
                    case "USD":
                        total = val * bgn / usd;
                        break;

                    case "EUR":
                        total = val * bgn / eur;
                        break;

                    case "GBP":
                        total = val * bgn / gbp;
                        break;
                }
            }

            else if (currency == "USD")
            {
                switch (convertedCurrency)
                {
                    case "BGN":
                        total = val * usd / bgn;
                        break;

                    case "EUR":
                        total = val * usd / eur;
                        break;

                    case "GBP":
                        total = val * usd / gbp;
                        break;
                }
            }

            Console.WriteLine($"{total:F2} {convertedCurrency}");
        }
    }
}
