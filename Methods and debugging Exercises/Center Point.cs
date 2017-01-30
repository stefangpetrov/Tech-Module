using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {

        static double DisBetweenPointNcentre(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
        static void ComparePoints(double x1, double y1, double x2, double y2)
        {
            double distance1 = DisBetweenPointNcentre(x1, y1);
            double distance2 = DisBetweenPointNcentre(x2, y2);
            if (distance1<=distance2)
                Console.WriteLine("(" + x1 + ", " + y1 + ")");
            else if (distance1 > distance2)
                Console.WriteLine("(" + x2 + ", " + y2 + ")");
            
        }

        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Compare(x1, y1, x2, y2);

        }
    }
}
