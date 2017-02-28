using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {

            
            int left = numbers[i];
            int rev = 0;
            while (left > 0)
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;
            }
            numbers[i] = rev;
                sum = sum + numbers[i];
            }

            Console.WriteLine(sum);

            
        }
    }
}
