using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Monkey : Animal
    {
        int dieUnder;
        public Monkey(int healthPoints, int dieUnder) : base(healthPoints)
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
