using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPower
    {
        static double Calculate(double number, int pow)
        {
            double Newnumber = Math.Pow(number, pow);
            return Newnumber;
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(number, pow));

        }
    }
}
