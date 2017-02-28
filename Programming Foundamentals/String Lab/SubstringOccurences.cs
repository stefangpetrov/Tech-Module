using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringOccurences
{
    class SubstringOccurences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            var index = 0;
            var count = 0;

            while (true)
            {
                var found = input.IndexOf(substring, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                    break;
            }
            Console.WriteLine(count);
        }
    }
}
