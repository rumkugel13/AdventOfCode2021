using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay14
    {
        [TestMethod]
        public void TestPart01()
        {
            Day14 day = new(File.ReadAllLines("day14example.txt"));

            Assert.AreEqual(1588, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Day14 day = new(File.ReadAllLines("day14example.txt"));

            Assert.AreEqual(2188189693529, day.SolvePart2());
        }
    }
}