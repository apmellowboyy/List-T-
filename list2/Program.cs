using System;
using System.Diagnostics.Metrics;

namespace foodListWhatFourIThink
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> foods = new List<string> { "pizza", "tacos", "bread", "popcorn", "oats" };
            string tempName = "lollipop";
            foods.Add(tempName);
            foods.Insert(0, "Grape");

            Console.WriteLine($"There original list has {foods.Count()} members");
            string[] memberArr = new string[] { "kimshi", "Ramen", "poptarts", "hot pockets" };
            foods.AddRange(memberArr);
            Console.WriteLine($"Your list contains {foods.Count()} amount of foods");

            Console.WriteLine("----OG List----");
            for (int i = 0; i < foods.Count(); i++)
                Console.WriteLine(foods[i]);

            foods.Remove("Ramen");
            foods.Remove(foods[2]);
            foods.RemoveRange(1, 2);

            Console.WriteLine($"The revised list now has {foods.Count()} members");
            Console.WriteLine("----Updated List----");
            for (int i = 0; i < foods.Count(); i++)
                Console.WriteLine(foods[i]);

            foods.Sort();
            Console.WriteLine("----Sorted List----");
            foreach (string m in foods)
                Console.WriteLine(m);
            foods.Reverse();
            Console.WriteLine("----Sorted but reverse because why not----");
            foreach (string m in foods)
                Console.WriteLine(m);


        }
    }
}