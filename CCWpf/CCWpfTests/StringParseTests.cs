using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CCWpfTests
{
    [TestFixture]
    public class StringParseTests
    {
        [TestCase(" 123 ", 123)]
        [TestCase(" -123 ", -123)]
        [TestCase("", 123, ExpectedException = typeof(FormatException))]
        public void GetnumberTest(string numberAsString, int expected)
        {
            int number = GetNumber(numberAsString);
            Assert.AreEqual(expected, number);
        }

        public int GetNumber(string numberAsString)
        {
            string trim = numberAsString.Trim();
            return int.Parse(trim);
        }
    }
}
