
namespace Bowling.LogicLayer
{
    public class BowlingGame
    {
        private int currentFrame = 0;
        private bool isFirstRoll = true;
        private ScoreCalculator gameScorer = new ScoreCalculator();

        public int FinalScore
        {
            get
            {
                return this.FrameScore(currentFrame);
            }
        }
        public void Add(int pins)
        {
            this.gameScorer.AddRoll(pins);

            if ((this.isFirstRoll && pins == 10) || (!this.isFirstRoll))
            {
                this.currentFrame++;

                if (this.currentFrame > 10)
                {
                    this.currentFrame = 10;
                }
            }
            else
            {
                this.isFirstRoll = false;
            }
        }
        public int FrameScore(int frame)
        {
            return this.gameScorer.FrameScore(frame);
        }
    }
}
