using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class AMinorTask
    {
        static void Main(string[] args)
        {
            var resourses = new Dictionary<string, long>();
            
            while(true)
            {
                var resourseName = Console.ReadLine();
                if (resourseName != "stop")
                {
                    if (!resourses.ContainsKey(resourseName))
                    {
                        long resourseQuantity = long.Parse(Console.ReadLine());
                        resourses[resourseName] = resourseQuantity;
                    }
                    else
                    {
                        long resourseQuantity = long.Parse(Console.ReadLine());
                        resourses[resourseName] += resourseQuantity;
                    }
                }
                else
                    break;
            }


            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
