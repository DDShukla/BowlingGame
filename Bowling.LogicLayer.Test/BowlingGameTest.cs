using NUnit.Framework;

namespace Bowling.LogicLayer.Test
{
    [TestFixture]
    public class GameTest
    {
        BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void GameScore_WhenNoThrows()
        {
            Assert.AreEqual(0, game.FinalScore);
        }

        [Test]
        public void GameScore_AddThrow()
        {
            game.Add(5);
            game.Add(4);
            Assert.AreEqual(9, game.FinalScore);
        }

        [Test]
        public void GameAndFrameScore_ThrowsWithNoMarks()
        {

            game.Add(3);
            game.Add(2);
            game.Add(5);
            game.Add(4);
            Assert.AreEqual(14, game.FinalScore);
            Assert.AreEqual(5, game.FrameScore(1));
            Assert.AreEqual(14, game.FrameScore(2));
        }

        [Test]
        public void GameAndFrameScore_WithSingleSpare()
        {
            game.Add(5);
            game.Add(5);
            game.Add(3);
            Assert.AreEqual(13, game.FrameScore(1));
        }

        [Test]
        public void GameAndFrameScore_TwoFrame_AfterFirstSpare()
        {
            game.Add(3);
            game.Add(7);
            game.Add(3);
            game.Add(2);
            Assert.AreEqual(13, game.FrameScore(1));
            Assert.AreEqual(18, game.FinalScore);
        }

        [Test]
        public void GameAndFrameScore_WithSingleStrike()
        {
            game.Add(10);
            Assert.AreEqual(10, game.FrameScore(1));
            Assert.AreEqual(10, game.FinalScore);
        }

        [Test]
        public void GameAndFrameScore_WithSingleStrikeOneFrame()
        {
            game.Add(10);
            game.Add(4);
            game.Add(5);
            Assert.AreEqual(19, game.FrameScore(1));
            Assert.AreEqual(28, game.FinalScore);
        }

        [Test]
        public void GameScore_HundredPercentStrike()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Add(10);
            }
            Assert.AreEqual(300, game.FinalScore);
        }

        [Test]
        public void GameScore_FailedStrike()
        {
            for (int i = 0; i < 10; i++)
            {
                game.Add(0);
            }

            Assert.AreEqual(0, game.FinalScore);
        }

        [Test]
        public void GameScore_BoundryCheckStrike()
        {
            for (int i = 0; i < 9; i++)
            {
                game.Add(0);
            }

            game.Add(4);
            game.Add(4);
            game.Add(10);

            Assert.AreEqual(18, game.FinalScore);
        }

        [Test]
        public void GameScore_SimpleFormat()
        {
            game.Add(1);
            game.Add(0);
            game.Add(1);
            game.Add(0);
            game.Add(1);
            game.Add(1);
            game.Add(1);
            game.Add(1);
            game.Add(1);
            game.Add(1);
            Assert.AreEqual(8, game.FinalScore);
        }

        [Test]
        public void GameScore_SimpleFormat_WithStrike()
        {
            game.Add(10);
            game.Add(1);
            game.Add(0);
            game.Add(10);
            game.Add(1);
            game.Add(1);
            game.Add(1);
            game.Add(1);
            Assert.AreEqual(28, game.FinalScore);
        }

        [Test]
        public void GameScore_BoundryMissed()
        {
            for (int i = 0; i < 11; i++)
            {
                game.Add(10);
            }

            game.Add(9);

            Assert.AreEqual(299, game.FinalScore);
        }

        [Test]
        public void GameScore_BoundrySpare()
        {
            for (int i = 0; i < 9; i++)
            {
                game.Add(10);
            }

            game.Add(5);
            game.Add(5);
            game.Add(1);
            Assert.AreEqual(266, game.FinalScore);
        }

        [Test]
        public void GameScore_BoundryOpen()
        {
            for (int i = 0; i < 9; i++)
            {
                game.Add(10);
            }

            game.Add(2);
            game.Add(2);
            Assert.AreEqual(250, game.FinalScore);
        }

    }
}