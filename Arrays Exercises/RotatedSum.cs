using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatedSum
{
    class RotatedSum
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[array.Length];
            int k = int.Parse(Console.ReadLine());

            int length = array.Length;
            for (int i = 0; i < k; i++)
            {
                int last = array[length - 1];
                for (int j = length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = last;
                
                for (int o = 0; o < sum.Length; o++)
                {
                    sum[o] = sum[o] + array[o];
                }
                
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
