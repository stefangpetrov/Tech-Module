using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {

            var cardPowers = GetCardPowers();
            var cardTypes = GetCardTypes();
            var input = Console.ReadLine();
            

            var cards = new Dictionary<string, HashSet<int>>();

            while (input != "JOKER")
            {
               
                var tokens = input.Split(':');
                var name = tokens[0];
                var playercards = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playercards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    var points = cardPowers[cardPower.ToString()] * cardTypes[cardType.ToString()];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }

                    cards[name].Add(points);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in cards)
            {
                var name = pair.Key;
                var playerscards = pair.Value.ToList();
                var sum = playerscards.Sum();
                Console.WriteLine($"{name}: {sum}");
            }
                 
        }

        private static Dictionary<string, int> GetCardTypes()
        {
            var cardTypes = new Dictionary<string, int>();
            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;

        }

        private static Dictionary<string, int> GetCardPowers()
        {
            var powers = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }

            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            return powers;
        }
    }
}
