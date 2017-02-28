using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void FaceDiagonal(double side)
        {
            double diagonal = Math.Sqrt(Math.Pow(side, 2) * 2);

            Console.WriteLine("{0:f2}", diagonal);
        }

        static void SpaceDiagonal(double side)
        {
            double diagonal = Math.Sqrt(Math.Pow(side, 2) * 3);

            Console.WriteLine("{0:f2}", diagonal);
        }

        static void Area(double side)
        {
            double area = Math.Pow(side, 2) * 6;

            Console.WriteLine("{0:f2}", area);
        }

        static void Volume(double side)
        {
            double volume = Math.Pow(side, 3);

            Console.WriteLine("{0:f2}", volume);
        }


        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            if (property == "face")
                FaceDiagonal(side);
            else if(property == "space")
                SpaceDiagonal(side);
            else if (property == "area")
                Area(side);
            else if (property == "volume")
                Volume(side);
        }
    }
}
