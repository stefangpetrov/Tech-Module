using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class LongerLine
    {
        

        static double DisBetweenTwoPoints(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(x1, 2)  + Math.Pow(y1, 2));
            return distance;
        }

        static void CompareLines(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double distancefromcen1 = DisBetweenTwoPoints(x1, y1);
            double distancefromcen2 = DisBetweenTwoPoints(x2, y2);
            double distancefromcen3 = DisBetweenTwoPoints(x3, y3);
            double distancefromcen4 = DisBetweenTwoPoints(x4, y4);
            double lengthLine1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            double lengthLine2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));

            if (lengthLine1 >= lengthLine2)
            {
                if (distancefromcen1 <= distancefromcen2)
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else Console.WriteLine($"({x2}, {y2})({x1}, {y1})");

                
            }
            else
                if (distancefromcen3 <= distancefromcen4)
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            else Console.WriteLine($"({x4}, {y4})({x3}, {y3})");


        }

        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            CompareLines(x1, y1, x2, y2, x3, y3, x4, y4);

        }
    }
}
