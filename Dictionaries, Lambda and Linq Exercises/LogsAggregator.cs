using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {

            var logsAggeregator = new SortedDictionary<string,Dictionary<string, int>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split();
                var ip = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);

                if (!logsAggeregator.ContainsKey(user))
                {

                    logsAggeregator.Add(user, new Dictionary<string, int>() { { ip, duration } });
                    
                }
                else
                    if (logsAggeregator[user].ContainsKey(ip))
                    {
                        logsAggeregator[user][ip] += duration;
                    }
                    else
                    {
                        logsAggeregator[user].Add(ip, duration);
                    }

            }

            foreach (var user in logsAggeregator)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");

                Console.Write(String.Join(", ", user.Value.Keys.OrderBy(x => x)));

                Console.WriteLine("]");
                
            }

        }
    }
}
