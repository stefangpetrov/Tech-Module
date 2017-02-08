using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurences
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }

                counts[word] += 1;

            }

            var result = new List<string>();
            foreach (var word in counts)
            {
                if(word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                    
                }
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
