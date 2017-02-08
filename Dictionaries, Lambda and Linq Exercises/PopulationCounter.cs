using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {

            var populationCounter = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while(input != "report")
            {
                var tokens = input.Split('|');
                var city = tokens[0];
                var population = long.Parse(tokens[2]);
                var country = tokens[1];

                if (!populationCounter.ContainsKey(country))
                    populationCounter.Add(country, new Dictionary<string, long>());

                if (!populationCounter[country].ContainsKey(city))
                    populationCounter[country].Add(city, population);


                input = Console.ReadLine();
            }

            

            foreach (var data in populationCounter.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var country = data.Key;
                

                long totalpopulation = 0;
                foreach (var things in data.Value)
                {
                    totalpopulation += things.Value;

                }

                Console.WriteLine($"{country} (total population: {totalpopulation})");

                foreach (var things in data.Value.OrderByDescending(x => x.Value))
                {
                    var city = things.Key;
                    var population = things.Value;
                    Console.WriteLine($"=>{city}: {population}");

                }


            }
        }
    }
}
