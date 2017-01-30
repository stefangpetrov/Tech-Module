using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfErathosthenes
{
    class SieveOfErathosthenes
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int i = 2; i < primes.Length; i++)
            {
                
                if (primes[i])
                {
                    for (int a = 2; a * i <= n; a++)
                    {
                        primes[a * i] = false;
                    }

                }

            }

            for (int j = 2; j <= n; j++)
            {
                if (primes[j] == true)
                    Console.Write(j + " ");
            }
        }
    }
}
