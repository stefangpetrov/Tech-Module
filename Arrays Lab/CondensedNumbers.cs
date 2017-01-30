using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondensedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];

           if(nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }

           else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < condensed.Length - i; j++)
                    {
                        condensed[j] = nums[j] + nums[j + 1];
                    }
                    nums = condensed;
                }

                Console.Write(condensed[0]);
            }

            
        }
    }
}
