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
        [TestCase("", 0)]
        [TestCase(null, 0)]
        [TestCase(" 123a ", 0)]
        public void GetnumberTest(string numberAsString, int expected)
        {
            int number = GetNumber(numberAsString);
            Assert.AreEqual(expected, number);
        }

        public int GetNumber(string numberAsString)
        {
            try
            {
                string trim = numberAsString.Trim();
                return int.Parse(trim);
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
