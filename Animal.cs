using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        public int healthPoints;

        public Animal(int healthPoints)
        {
            this.healthPoints = healthPoints;
        }

        public void Starve(int healthPointsToRemove)
        {
            healthPoints -= healthPointsToRemove;
        }
        public void Feed(int healthPointToAdd)
        {
            healthPoints += healthPointToAdd;
        }
        public abstract bool IsAlive();
    }
}
