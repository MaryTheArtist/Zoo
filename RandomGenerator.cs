using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class RandomGenerator
    {
        private readonly Random random = new Random();

        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
