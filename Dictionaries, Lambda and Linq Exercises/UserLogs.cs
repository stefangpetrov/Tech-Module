using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userlogs = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while(input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);                
                var ip = tokens[1];
                var message = tokens[3];
                var username = tokens[5];

                
                
                if (!userlogs.ContainsKey(username))
                    userlogs.Add(username, new Dictionary<string, int>());


                if (!userlogs[username].ContainsKey(ip))
                    userlogs[username].Add(ip, 1);
                else
                    userlogs[username][ip]++;



                input = Console.ReadLine();
            }

            foreach (var user in userlogs)
            {
                var name = user.Key;
                var log = user.Value;
               

                Console.WriteLine($"{name}: ");
                foreach (var person in log)
                {
                    var ip = person.Key;
                    var counter = person.Value;

                    if (ip != log.Keys.Last())
                        Console.Write($"{ip} => {counter}, ");
                    else
                        Console.WriteLine($"{ip} => {counter}.");

                }
                



            }


        }
    }
}
