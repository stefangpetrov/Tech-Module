using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class TriangleArea
    {
       static double CalculateArea(double width, double height)
       {
            double Area = (width * height) / 2;
            return Area;
            
       }

        static void Main(string[] args)
        {
            double width =  double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateArea(width, height);
            Console.WriteLine(area);
        }
    }
}
