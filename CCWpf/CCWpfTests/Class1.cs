﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace CCWpfTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetNameTest()
        {
            string fullName = "Johan Larsson";
            string[] strings = GetNames(fullName);
            Assert.IsTrue(new[]{"Johan","Larsson"}.SequenceEqual(strings));
        }

        public string[] GetNames(string fullName)
        {
            string firstName = "firstName";
            string lastname = "lastName";
            var regex = new Regex(string.Format(@"(?<{0}>\w*) (?<{1}>\w*)", firstName, lastname));
            if(!regex.IsMatch(fullName))
                throw new ArgumentException("Regex does not match","fullName");
            Match match = regex.Match(fullName);
            return new string[] { match.Groups[firstName].Value, match.Groups[lastname].Value };
        }
    }
}
