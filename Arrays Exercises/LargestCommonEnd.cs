using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');
            string[] elements2 = Console.ReadLine().Split(' ');

            int minLen = Math.Min(elements.Length, elements2.Length);
            int maxLen = Math.Max(elements.Length, elements2.Length);

            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < minLen; i++)
            {
                if (elements[i] == elements2[i])
                    countLeft++;
                else
                    break;
            }

            while (countRight < elements.Length && countRight < elements2.Length)
            {
                if (elements[elements.Length - countRight - 1] == elements2[elements2.Length - countRight - 1])
                {
                    countRight++;
                }
                else break;
            }

            if(countRight>countLeft)
            {
                Console.WriteLine(countRight);
            }
            else
                Console.WriteLine(countLeft);

        }
    }
}
