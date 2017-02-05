using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squarenums = new List<int>(); 
             
            foreach(int number in numbers)
            {
                if(CheckSquare(number))
                {
                    squarenums.Add(number);
                }
            }
            squarenums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(" ", squarenums));
        }

        private static bool CheckSquare(int number)
        {
            if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                return true;
            else
                return false;
        }
    }
}
