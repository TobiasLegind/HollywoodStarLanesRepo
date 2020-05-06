namespace HollywoodStarLanes
{
    public class ScoreCalculator
    {
        private readonly Frame[] _framesOfPlayer = new Frame[10];
        private int _frameIndex;
        private Frame PreviousFrame => _framesOfPlayer[_frameIndex - 1];
        private Frame TwoRollsAgoFrame => _framesOfPlayer[_frameIndex - 2];
        public int AggregatedScore { get; private set; }

        public void BowlFrame(Frame frame)
        {
            if (_frameIndex > 0)
            {
                AggregatedScore += GetBonusScore(frame);
            }
            AggregatedScore += frame.FrameScore;
            _framesOfPlayer[_frameIndex++] = frame;
        }

        private int GetBonusScore(Frame frame)
        {
            if (_frameIndex +1 == _framesOfPlayer.Length)
                return frame.FrameScore;
            if (_frameIndex >= 2 && PreviousFrame.RollWasStrike && TwoRollsAgoFrame.RollWasStrike)
                return  frame.FrameScore + frame.FirstRoll;
            if (PreviousFrame.RollWasStrike)
                return frame.FrameScore;
            return PreviousFrame.RollWasSpare ? frame.FirstRoll : 0;
        }
    }
}
