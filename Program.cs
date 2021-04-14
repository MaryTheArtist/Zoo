using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Zoo
{
    class Program
    {
        private const int healthPoints = 100, elephantDieUnder = 70, leoDieUnder = 50, monkeyDieUnder = 40;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Zoo! We have 5 Monkeys, 5 Leos and 5 Elephants. " +
                "The animals have 100 health points each. " +
                "The monkey will die when its health points fall below 40." +
                "The lion will die when his health points fall below 50." +
                "The elephant dies when it cannot walk." +
                "He cannot walk when his health scores fall below 70. " +
                "All animals starve and feed at any number of points in range 0 - 20 and 5 - 25 respectively. ");

            Console.Write("Choose how many times to starve and feed the animals: ");
            int countStarvationFeeding = int.Parse(Console.ReadLine());

            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < 5; i++)
            {
                // Add animal and its health points and die under points.
                animals.Add(new Elephant(healthPoints, elephantDieUnder));
                animals.Add(new Leo(healthPoints, leoDieUnder));
                animals.Add(new Monkey(healthPoints, monkeyDieUnder));
            }

            var generator = new RandomGenerator();

            // Starve and Feed all animals.
            for (int i = 0; i < countStarvationFeeding; i++)
            {
                foreach (var a in animals)
                {
                    int starvation = generator.RandomNumber(0, 50); //0, 20
                    int feeding = generator.RandomNumber(5, 25);

                    a.Starve(starvation);
                    a.Feed(feeding);
                }
            }

            int liveElephants = 0, liveLeos = 0, liveMonkeys = 0;

            // Count live animals.
            foreach (var a in animals)
            {
                bool isAlive = a.IsAlive();
                if (isAlive)
                {
                    if (a is Elephant)
                    {
                        liveElephants++;
                    }
                    else if (a is Leo)
                    {
                        liveLeos++;
                    }
                    else
                    {
                        liveMonkeys++;
                    }
                }
            }

            Console.WriteLine("There are {0} live elephants, {1} live leos, {2} live monkeys.", liveElephants, liveLeos, liveMonkeys);
        }
    }
}
