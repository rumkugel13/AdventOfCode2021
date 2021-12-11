using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay11
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day11example.txt");
            Day11 day = new(input);

            Assert.AreEqual(1656, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day11example.txt");
            Day11 day = new(input);

            Assert.AreEqual(195, day.SolvePart2());
        }
    }
}