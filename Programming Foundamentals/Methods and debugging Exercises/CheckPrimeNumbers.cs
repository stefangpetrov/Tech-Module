using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrimeNumbers
{
    class CheckPrimeNumbers
    {

        static bool IsPrime(long number)
        {

            bool isPrime = true;
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (number == 1 || number == 0)
                return false;
            else
                return isPrime;
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));

        }
    }
}
