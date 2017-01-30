using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static List<int> CheckPrimeNums(int start, int end)
        {
            List<int> primes = new List<int>();

            if (start < 2)  //We don't need to check for 0 and 1.
            {
                start = 2;
            }


            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;                

                for (int j = 2; j*j <= i; j++) 
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    primes.Add(i);
            }

            return primes;
        }

        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> primes = CheckPrimeNums(start, end);

            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i]);
                if (i == primes.Count - 1)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write(", ");
            }

        }
    }
}
