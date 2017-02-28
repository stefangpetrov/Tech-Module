using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());



            double treshold = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double div = Rate(last, price);
                bool isSignificantDifference = imaliDif(div, treshold);
                string message = Get(price, last, div, isSignificantDifference);
                Console.WriteLine(message);
                last = price;
            }
        }

        private static string Get(double currentrice, double last, double difference, bool eitherTrueOrFalse)
        {
            string to = "";
            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", currentrice);
            }
            else if (!eitherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, currentrice, difference*100);
            }
            else if (eitherTrueOrFalse && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, currentrice, difference*100);
            }
            else if (eitherTrueOrFalse && (difference < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, currentrice, difference*100);
            return to;
        }


        private static bool imaliDif(double treshold, double isDiff)
        {
            if (Math.Abs(treshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Rate(double lastprice, double currentprice)
        {
            double rate = (currentprice - lastprice) / lastprice;
            return rate;
        }
    }
}
