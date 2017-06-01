using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKata.Services.NotationConverter;
using BowlingKata.Features.CalculateBowlingGame;
using System.Collections.Generic;

namespace BowlingKata.Tests.Integration
{
    [TestClass]
    public class NotationConverterService_BowlingGame_Tests
    {
        [TestMethod]
        public void PerfectGameStringEquals300()
        {
            IBowlingGame game = new BowlingGame();

            foreach (var roll in new NotationConverterService().ConvertNotation("XXXXXXXXXXXX"))
            {
                game.AddRoll(roll);
            }

            Assert.AreEqual(300, game.GetTotalScore());
        }

        [TestMethod]
        public void IncrementalSparesStringEquals153()
        {
            IBowlingGame game = new BowlingGame();

            foreach (var roll in new NotationConverterService().ConvertNotation("1/2/3/4/5/6/7/8/9/0/9"))
            {
                game.AddRoll(roll);
            }

            Assert.AreEqual(153, game.GetTotalScore());
        }

        [TestMethod]
        public void GutterBallGameStringEquals0()
        {
            IBowlingGame game = new BowlingGame();

            foreach (var roll in new NotationConverterService().ConvertNotation("00000000000000000000"))
            {
                game.AddRoll(roll);
            }

            Assert.AreEqual(0, game.GetTotalScore());
        }

        [TestMethod]
        public void TypicalGameStringCalculates()
        {
            IBowlingGame game = new BowlingGame();

            foreach (var roll in new NotationConverterService().ConvertNotation("8/729/X54X900/X6/X"))
            {
                game.AddRoll(roll);
            }

            Assert.AreEqual(162, game.GetTotalScore());
        }
    }
}
