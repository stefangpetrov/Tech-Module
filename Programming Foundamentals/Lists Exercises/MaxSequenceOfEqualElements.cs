using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int start = 0;
            int len = 1;
            int beststart = 0;
            int bestlen = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                    len++;
                else
                {
                    start = i;
                    len = 1;
                }

                if(len > bestlen)
                {
                    beststart = start;
                    bestlen = len;
                }
            }

            for (int i = beststart; i < beststart + bestlen; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
