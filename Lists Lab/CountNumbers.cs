using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] count = new int[numbers.Max() + 1];

            foreach (var number in numbers)
            {
                count[number]++;

            }
            for (int i = 0; i < count.Length; i++)
            {
                if(count[i] >= 1)
                    Console.WriteLine($"{i} -> {count[i]} ");
            }
        }
    }
}
