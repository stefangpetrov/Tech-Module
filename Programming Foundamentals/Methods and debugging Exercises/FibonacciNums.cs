using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciNums
    {
        static long Fibonacci(long number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
            {
                int p = 0;
                int c = 1;
                int r = 0; // The result is initialized to 0 (undefined). 
                for (int i = 0; i < number; i++)
                {
                    r = p + c; // Produce next number in the sequence.
                    p = c;     // Save previous number.
                    c = r;     // Save current number.

                    
                }

                return r;
            }

        }
        
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));
        }
    }
}
