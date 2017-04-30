
using SimpleInjector;
using System.Collections.Generic;
namespace Bowling.LogicLayer
{
    public class BowlingGameService
    {
        private readonly Container _container;
        public BowlingGameService(Container container)
        {
            _container = container;
        }

        public int GetScoreByAllRolls(int[] rolls)
        {
            BowlingGame game = _container.GetInstance<BowlingGame>();

            for (int i = 0; i < rolls.Length; i++)
            {
                game.Add(rolls[i]);
            }
            return game.FinalScore;
        }

        public List<int> GetAllFramesResultByRolls(int[] rolls)
        {
            BowlingGame game = _container.GetInstance<BowlingGame>();

            List<int> frameResult = new List<int>();

            for (int i = 0; i < rolls.Length; i++)
            {
                game.Add(rolls[i]);
            }

            for (int j = 1; j <= 10; j++)
            {
                frameResult.Add(game.FrameScore(j));

            }

            return frameResult;
        }

    }
}
