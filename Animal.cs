using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        public int healthPoints;
        public int dieUnder;
        public Animal(int healthPoints, int dieUnder)
        {
            this.healthPoints = healthPoints;
            this.dieUnder = dieUnder;
        }
        public void Starve(int healthPointsToRemove)
        {
            healthPoints -= healthPointsToRemove;
        }
        public void Feed(int healthPointToAdd)
        {
            healthPoints += healthPointToAdd;
        }
        public bool IsAlive()
        {
            bool isAlive = true;

            if (healthPoints < dieUnder)
            {
                isAlive = false;
            }
            return isAlive;
        }
    }
}
