using System;

namespace HollywoodStarLanes
{
    public class Frame
    {
        protected const int LeastValueOfPins = 0;
        protected const int HighestValueOfPins = 10;
        public int FirstRoll { get; set; } 
        public int SecondRoll { get; set; }
        public virtual int FrameScore => FirstRoll + SecondRoll;
        public bool RollWasStrike => FirstRoll + SecondRoll == HighestValueOfPins;
        public bool RollWasSpare => FirstRoll + SecondRoll == HighestValueOfPins && !RollWasStrike;
        public Frame(int firstRoll, int secondRoll)
        {
            ValidateFrame(firstRoll, secondRoll);

            FirstRoll = firstRoll;
            SecondRoll = secondRoll;
        }

        protected Frame()
        {
            
        }

        private void ValidateFrame(int firstRoll, int secondRoll)
        {
            if (firstRoll < LeastValueOfPins || secondRoll < LeastValueOfPins)
            {
                throw new System.ArgumentException($"Value cannot be less than {LeastValueOfPins}... Man!");
            }

            if (firstRoll + secondRoll > HighestValueOfPins)
            {
                throw new System.ArgumentException($"Value cannot be higher than {HighestValueOfPins}... Man!");
            }

            if (firstRoll < 0) throw new ArgumentOutOfRangeException(nameof(firstRoll));
            if (secondRoll < 0) throw new ArgumentOutOfRangeException(nameof(secondRoll));
        }
    }
}
