using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindSumAndRaz;
using System.Collections.Generic;

namespace TestingSumAndRaz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodError()
        {
            int a1 = 5, b1 = 2;
            FindingElement findingEl = new FindingElement();

            var expected1 = new List<int> { 7, 3 };
            var actual1 = findingEl.SumAndRaz(a1, b1);

            Assert.AreEqual(expected1, actual1, "error is SumAndRaz");
        }

        [TestMethod]
        public void TestMethodProblemTest()
        {
            int a = 3, b = 3;
            FindingElement findingEl = new FindingElement();

            var expected1 = 6;
            var expected2 = 1;
            var actual1 = findingEl.SumAndRaz(a, b)[0];
            var actual2 = findingEl.SumAndRaz(a, b)[1];

            Assert.AreEqual(expected1, actual1, "error is SumAndRaz");
            Assert.AreEqual(expected2, actual2, "error is SumAndRaz");
        }

        [TestMethod]
        public void TestMethodRight()
        {
            int a = 3, b = 3;
            FindingElement findingEl = new FindingElement();

            var expected1 = 6;
            var expected2 = 0;
            var actual1 = findingEl.SumAndRaz(a, b)[0];
            var actual2 = findingEl.SumAndRaz(a, b)[1];

            Assert.AreEqual(expected1, actual1, "error is SumAndRaz");
            Assert.AreEqual(expected2, actual2, "error is SumAndRaz");
        }
    }
}
