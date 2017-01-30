using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static bool IsPalindrome(int num)
        {
            int n = num;
            int digit = 0;
            int rev = 0;
            while (num > 0)
            {
                digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }

            if (rev == n)
                return true;
            else
                return false;
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;

            while(num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }

            if (sum % 7 == 0)
                return true;
            else
                return false;
        }

        static bool ContainsEvenDigits(int num)
        {
            int digit = 0;
            while (num != 0)
            {
                digit =  num % 10;
                if(digit % 2 == 0)
                {
                    break;
                }
                num = num / 10;
            }

            if (digit % 2 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                if(IsPalindrome(i) && ContainsEvenDigits(i) && SumOfDigits(i))
                    Console.WriteLine(i);
            }
        }
    }
}
