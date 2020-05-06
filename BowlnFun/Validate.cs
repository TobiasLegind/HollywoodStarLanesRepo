using System;
using System.Collections.Generic;
using System.Text;

namespace HollywoodStarLanes
{
    public class Validate
    {
        public bool ValidateFrame(int firstRoll, int secondRoll, int LeastValueOfPins, int HighestValueOfPins)
        {
            if (firstRoll < LeastValueOfPins || secondRoll < LeastValueOfPins)
            {
                throw new System.ArgumentException($"Value cannot be less than {LeastValueOfPins}... Man!");
            }

            if (firstRoll + secondRoll > HighestValueOfPins)
            {
                throw new System.ArgumentException($"Value cannot be higher than {HighestValueOfPins}... Man!");
            }
            return true;
        }
    }
}
