using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CCWpfTests
{
    [TestFixture]
    class LinqTests
    {
        [Test]
        public void TestNameTest()
        {
            var ints = new List<int> {1, 2, 3, 4, 5, 6};

            var filtered = ints.Where(x => x >= ints.Max() - 2);

            Assert.IsTrue(new[]{4,5,6}.SequenceEqual(filtered));
        }
    }
}
