using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MultiplyByBigNumber
{
    class MultiplyByBigNumber
    {
        static void Main(string[] args)
        {
            var number = BigInteger.Parse(Console.ReadLine());
            var multiply = int.Parse(Console.ReadLine());

            Console.WriteLine(number * multiply);
        }
    }
}
