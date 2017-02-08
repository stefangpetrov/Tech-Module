using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associative_arrays
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            List<double> realnumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var counts = new SortedDictionary<double, int>();

            foreach (var number in realnumbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;

                }
                else
                    counts[number] = 1;
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value} times");
            }
            

        }
    }
}
