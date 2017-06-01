using BowlingKata.Features.CalculateBowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKata.Tests.Features.CalculateBowlingGame
{
    [TestClass]
    public class BowlingGameTests
    {
        [TestMethod]
        public void TestGutterGame()
        {
            var game = new BowlingGame();
            for (int i = 0; i < 20; i++)
            {
                game.AddRoll(0);
            }
            Assert.AreEqual(0, game.GetTotalScore());
        }

        [TestMethod]
        public void TestSpareGame()
        {
            var game = new BowlingGame();
            for (int i = 0; i <= 20; i++)
            {
                game.AddRoll(5);
            }
            Assert.AreEqual(150, game.GetTotalScore());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            var game = new BowlingGame();
            for (int i = 0; i <= 11; i++)
            {
                game.AddRoll(10);
            }
            Assert.AreEqual(300, game.GetTotalScore());
        }

        [TestMethod]
        public void TestTypicalGame()
        {
            var game = new BowlingGame();
            game.AddRoll(8);
            game.AddRoll(2);

            game.AddRoll(10);

            game.AddRoll(0);
            game.AddRoll(10);

            game.AddRoll(9);
            game.AddRoll(0);

            game.AddRoll(8);
            game.AddRoll(1);

            game.AddRoll(10);

            game.AddRoll(9);
            game.AddRoll(1);

            game.AddRoll(7);
            game.AddRoll(3);

            game.AddRoll(10);

            game.AddRoll(10);
            game.AddRoll(9);
            game.AddRoll(1);

            Assert.AreEqual(183, game.GetTotalScore());
        }
    }
}
