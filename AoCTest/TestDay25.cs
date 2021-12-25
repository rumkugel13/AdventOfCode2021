using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay25
    {
        [TestMethod]
        public void TestPart01()
        {
            Day25 day = new(File.ReadAllLines("day25example.txt"));

            Assert.AreEqual(58, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Day25 day = new(File.ReadAllLines("day25example.txt"));

            Assert.AreEqual(0, day.SolvePart2());
        }
    }
}