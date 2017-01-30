﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class LastKNumbersSum
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                        sum = sum + arr[j];
                    else
                        continue;
                }
                arr[i] = sum;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
