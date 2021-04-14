using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Leo : Animal
    {
        int dieUnder;
        public Leo(int healthPoints, int dieUnder) : base(healthPoints)
        {
            this.dieUnder = dieUnder;
        }
        public override bool IsAlive()
        {
            bool isAlive = true;

            if(healthPoints < dieUnder)
            {
                isAlive = false;
            }

            return isAlive;
        }
    }
}
