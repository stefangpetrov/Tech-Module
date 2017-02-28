using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();
            items.Reverse();


            foreach(var item in items)
            {
                List<string> nums = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
