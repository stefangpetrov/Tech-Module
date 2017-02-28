using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBase10
{
    class ConvertFromBase10
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var number = BigInteger.Parse(input[1]);
            var system = int.Parse(input[0]);
            var result = "";

            while (number > 0)
            {
                var remainder = number % system;
                result = remainder + result;

                number /= system;
            }

            Console.WriteLine(result);
        }
    }
}
