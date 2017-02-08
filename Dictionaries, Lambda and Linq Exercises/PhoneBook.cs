using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        static void Main(string[] args)
        {

            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "A")
                {
                    Add(phonebook, command);
                }
                else if (command[0] == "S")
                {
                    Search(phonebook, command);
                }
                else
                    break;
            }
        }

        private static void Search(Dictionary<string, string> phonebook, List<string> command)
        {
            int count = 0;
            string itemvalue = "";
            foreach (var item in phonebook)
            {
                if (item.Key == (command[1]))
                {                    
                    count++;
                    itemvalue = item.Value;
                }

            }

            if(count == 0)
                Console.WriteLine($"Contact {command[1]} does not exist.");
            else
                Console.WriteLine($"{command[1]} -> {itemvalue}");
            
        }



        private static Dictionary<string, string> Add(Dictionary<string, string> phonebook, List<string> command)
        {
                     
                phonebook[command[1]] = command[2];
            


            return phonebook;
        }
    }
}
