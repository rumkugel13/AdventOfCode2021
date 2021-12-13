using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay13
    {
        [TestMethod]
        public void TestPart01()
        {
            Day13 day = new(File.ReadAllLines("day13example.txt"));

            Assert.AreEqual(17, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Day13 day = new(File.ReadAllLines("day13example.txt"));

            Assert.AreEqual(-1, day.SolvePart2());
        }
    }
}