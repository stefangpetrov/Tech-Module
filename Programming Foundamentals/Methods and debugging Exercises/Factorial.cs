using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {


        static BigInteger FactorialNumber(int number)
        {
            BigInteger factorial = number;
            for (int i = number - 1; i >= 1; i--)

            {

                factorial = factorial * i;

            }

            return factorial;
        }
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());

            Console.WriteLine(FactorialNumber(factorial));

        }
    }
}
