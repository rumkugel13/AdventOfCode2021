using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay24
    {
        [TestMethod]
        public void TestPart01()
        {
            Day24 day = new(File.ReadAllLines("day24example.txt"));

            Assert.AreEqual(0, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Day24 day = new(File.ReadAllLines("day24example.txt"));

            Assert.AreEqual(0, day.SolvePart2());
        }
    }
}