using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int count = 1;
            int biggestcount = 0;
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        count++;
                }

                if(count>biggestcount)
                {
                    biggestcount = count;
                    position = i;
                }

                count = 1;
            }

            Console.Write(array[position]);

        }
    }
}
