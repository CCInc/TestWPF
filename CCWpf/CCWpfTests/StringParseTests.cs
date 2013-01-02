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
        [Test]
        public void GetnumberTest()
        {
            string s = " 123 ";
            int number = GetNumber(s);
            Assert.AreEqual(123,number);
        }

        public int GetNumber(string numberAsString)
        {
            string trim = numberAsString.Trim();
            return int.Parse(trim);
        }
    }
}
