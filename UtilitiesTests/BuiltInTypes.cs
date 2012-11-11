using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace UtilitiesTests
{
    [TestClass]
    public class BuiltInTypes
    {
        [TestMethod]
        public void EvenTestIsEven()
        {
            Assert.IsTrue(2.IsEven());

            Assert.IsTrue(64.IsEven());

            Assert.IsTrue(1000000000.IsEven());

            Assert.IsTrue((-2).IsEven());

            Assert.IsTrue((-1000000).IsEven());

            Assert.IsTrue(0.IsEven());
        }

        [TestMethod]
        public void OddTestIsEven()
        {
            Assert.IsFalse(1.IsEven());

            Assert.IsFalse(63.IsEven());

            Assert.IsFalse(1000000001.IsEven());

            Assert.IsFalse((-3).IsEven());

            Assert.IsFalse((-1000001).IsEven());
        }
    }
}
