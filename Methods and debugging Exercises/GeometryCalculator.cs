using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Trianglearea(double side, double height)
        {
            double area = (side * height) / 2;

            Console.WriteLine("{0:f2}", area);
        }

        static void Rectanglearea(double width, double height)
        {
            double area = width * height;

            Console.WriteLine("{0:f2}", area);
        }

        static void Circlearea(double radius)
        {
            double area = Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine("{0:f2}", area);
        }

        static void Squareearea(double side)
        {
            double area = side * side;

            Console.WriteLine("{0:f2}", area);
        }


        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if(figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Trianglearea(side, height);

            }

            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Rectanglearea(width, height);

            }

            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Squareearea(side);

            }

            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Circlearea(radius);

            }
        }
    }
}
