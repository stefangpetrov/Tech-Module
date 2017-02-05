using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "add")
                {
                    Add(numbers, command);
                }
                else if (command[0] == "addMany")
                {
                    AddMany(numbers, command);
                    
                }
                else if (command[0] == "contains")
                {
                    Console.WriteLine(Contains(numbers, command));
                }
                else if (command[0] == "remove")
                {
                    Remove(numbers, command);
                }
                else if (command[0] == "shift")
                {
                    Shift(numbers, command);
                }
                else if (command[0] == "sumPairs")
                {
                    Sumpairs(numbers);
                }
                else
                    break;
                

            }

            Console.Write("[");
            Console.Write(String.Join(", ", numbers));
            Console.Write("]");

           
        }

        public static List<int> Sumpairs(List<int> numbers)
        {
            List<int> summedPairs = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                summedPairs.Add(numbers[i] + numbers[i + 1]);
            }

            if (numbers.Count % 2 != 0)
            {
                summedPairs.Add(numbers.Last());
            }

            numbers.Clear();
            numbers.AddRange(summedPairs);
            summedPairs.Clear();
            return numbers;
        }


        private static List<int> Shift(List<int> numbers, string[] command)
        {
            int shiftedValue = Convert.ToInt32(command[1]) % numbers.Count;
            List<int> shiftedNumbers = numbers.Take(shiftedValue).ToList();
            numbers.RemoveRange(0, shiftedValue);
            numbers.AddRange(shiftedNumbers);

            return numbers;
        }

        private static List<int> Remove(List<int> numbers, string[] command)
        {
            numbers.Remove(numbers[Convert.ToInt32(command[1])]);
            return numbers;
        }

        private static int Contains(List<int> numbers, string[] command)
        {
            
            int index = - 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Convert.ToInt32(command[1]) == numbers[i])
                {
                    index = i;
                    break;
                }
            }
            
            return index;
        }

        private static List<int> AddMany(List<int> numbers, string[] command)
        {
            List<int> addNumbers = new List<int>();
            for (int i = 2; i < command.Length; i++)
            {
                addNumbers.Add(Convert.ToInt32(command[i]));
            }

            numbers.InsertRange(Convert.ToInt32(command[1]), addNumbers);

            return numbers;
        }

        private static List<int> Add(List<int> numbers, string[] command)
        {
            numbers.Insert(Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
            return numbers;
        }
    }
}
