using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
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

        static int TrailingZeroes( int number)
        {
            BigInteger factorial = FactorialNumber(number);
            int count = 0;
            while (factorial % 10 == 0)
            {
                count++;
                factorial = factorial / 10;
                               
            }
            return count;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroes(number));




        }
    }
}
