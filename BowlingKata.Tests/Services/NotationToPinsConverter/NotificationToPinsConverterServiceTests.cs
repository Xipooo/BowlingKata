using BowlingKata.Services.NotationConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BowlingKata.Tests.Services.NotationToPinsConverter
{
    [TestClass]
    public class NotificationToPinsConverterServiceTests
    {
        [TestMethod]
        public void StrikeNotationConvertsToListOfIntsWithValueOf10()
        {
            INotationConverterService notationConverter = new NotationConverterService();
            IList<int> pins = notationConverter.ConvertNotation("XXXXXXXXXXXX");
            List<int> expected = new List<int> { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], pins[i]);
            }
        }

        [TestMethod]
        public void SpareNotationConvertsToListOfIntsWithValueOf10MinusPreviousRoll()
        {
            INotationConverterService notationConverter = new NotationConverterService();
            IList<int> pins = notationConverter.ConvertNotation("1/2/3/4/5/6/7/8/9/0/9");

            List<int> expected = new List<int>
            {
                1,9,2,8,3,7,4,6,5,5,6,4,7,3,8,2,9,1,0,10,9
            };

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], pins[i]);
            }
        }

        [TestMethod]
        public void NumbersInNotationConvertToListOfInts()
        {
            INotationConverterService notationConverter = new NotationConverterService();
            IList<int> pins = notationConverter.ConvertNotation("18273645546372819000");

            List<int> expected = new List<int>
            {
                1,8,2,7,3,6,4,5,5,4,6,3,7,2,8,1,9,0,0,0
            };

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], pins[i]);
            }
        }

        [TestMethod]
        public void NotationConverterUsingCommaSeparatedValues()
        {
            INotationConverterService notationConverter = new NotationConverterService();
            IList<int> pins = notationConverter.ConvertNotation("1/,2/,3/,4/,5/,6/,7/,8/,9/,0/9");

            List<int> expected = new List<int>
            {
                1,9,2,8,3,7,4,6,5,5,6,4,7,3,8,2,9,1,0,10,9
            };

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], pins[i]);
            }
        }
    }
}
