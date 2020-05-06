using System;
using System.Collections.Generic;
using System.Text;

namespace HollywoodStarLanes
{
    public class LastFrame : Frame
    {
        public int ThirdRoll { get; set; }
        public override int FrameScore => base.FrameScore + ThirdRoll;

        public LastFrame(int firstRoll, int secondRoll, int thirdRoll)
        {
            ValidateFrame(firstRoll, secondRoll, thirdRoll);
            FirstRoll = firstRoll;
            SecondRoll = secondRoll;
            ThirdRoll = thirdRoll;
        }
        private void ValidateFrame(int first, int second, int third)
        {
            if (first + second < HighestValueOfPins && third > 0)
            {
                throw new System.ArgumentException($"No third shoot, without spare or strike... Man!");
            }
            if (first < LeastValueOfPins || second < LeastValueOfPins || third < LeastValueOfPins)
            {
                throw new System.ArgumentException($"Value cannot be less than {LeastValueOfPins}... Man!");
            }

            if (first > HighestValueOfPins || second > HighestValueOfPins || third > HighestValueOfPins)
            {
                throw new System.ArgumentException($"Value cannot be higher than {HighestValueOfPins}... Man!");
            }

            if (first < 0) throw new ArgumentOutOfRangeException(nameof(first));
            if (second < 0) throw new ArgumentOutOfRangeException(nameof(second));
            if (third < 0) throw new ArgumentOutOfRangeException(nameof(third));
        }
    }
}
