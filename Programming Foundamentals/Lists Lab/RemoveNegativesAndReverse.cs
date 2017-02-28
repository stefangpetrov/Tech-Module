using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nonegatives = new List<int>();
    
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                    nonegatives.Add(numbers[i]);
            }
            if (nonegatives.Count == 0)
                Console.WriteLine("empty");
            else
            {
                nonegatives.Reverse();
                for (int i = 0; i < nonegatives.Count; i++)
                {
                    Console.Write(nonegatives[i] + " ");
                }
            }
        }
    }
}
