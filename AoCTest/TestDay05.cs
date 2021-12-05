using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay05
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day05example.txt");
            Day05 day05 = new Day05(input);

            Assert.AreEqual(5, day05.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day05example.txt");
            Day05 day05 = new Day05(input);

            Assert.AreEqual(12, day05.SolvePart2());
        }
    }
}