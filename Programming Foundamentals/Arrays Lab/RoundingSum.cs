using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingSum
{
    class RoundingSum
    {
        static void Main(string[] args)
        {

            string[] nums1 = Console.ReadLine().Split();
            double[] nums = new double[nums1.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToDouble(nums1[i]);
            }
            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                roundedNums[i] = (int)Math.Round(nums[i],
                MidpointRounding.AwayFromZero);

            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine($"{nums[i]} -> {roundedNums[i]}");
        }
    }
}
