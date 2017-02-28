using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            var first = BigInteger.Parse(Console.ReadLine());
            var second = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(first + second);
        }
    }
}
