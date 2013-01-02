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
        [TestCase(" 1234 ", 0, ExpectedException = typeof(ArgumentOutOfRangeException))]
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
                int i = int.Parse(trim);
                if (i > 999)
                    throw new ArgumentOutOfRangeException("i");
                return i;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
