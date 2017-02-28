using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {

            var personalEmail = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name != "stop")
                {
                    if (!personalEmail.ContainsKey(name))
                    {
                        string email = Console.ReadLine();
                        personalEmail[name] = email;
                    }
                    else
                    {
                        string email = Console.ReadLine();
                        personalEmail[name] = email;
                    }
                }
                else
                    break;
            }


            foreach (var item in personalEmail)
            {
                if(!(item.Value.Contains(".us") || item.Value.Contains(".uk")))
                    Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
