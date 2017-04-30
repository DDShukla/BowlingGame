
namespace Bowling.LogicLayer
{
    class ScoreCalculator
    {
        private int ball;
        private int[] rolls = new int[21];
        private int currentRoll;
        public void AddRoll(int pins)
        {
            rolls[currentRoll++] = pins;
        }
        public int FrameScore(int frame)
        {
            ball = 0;
            int score = 0;

            for (int index = 0; index < frame; index++)
            {
                if (Strike())
                {
                    score += 10 + (rolls[ball + 1] + rolls[ball + 2]);
                    ball += 1;
                }
                else if (Spare())
                {
                    score += 10 + (rolls[ball + 2]);
                    ball += 2;
                }
                else
                {
                    score += (rolls[ball] + rolls[ball + 1]);
                    ball += 2;
                }
            }
            return score;
        }
        private bool Strike()
        {
            return rolls[ball] == 10;
        }
        private bool Spare()
        {
            return rolls[ball] + rolls[ball + 1] == 10;
        }
    }
}
