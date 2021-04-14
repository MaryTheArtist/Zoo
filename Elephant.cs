using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant : Animal
    {
        int dieUnder;
        public Elephant(int healthPoints, int dieUnder) : base(healthPoints)
        {
            this.dieUnder = dieUnder;
        }
        public override bool IsAlive()
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
