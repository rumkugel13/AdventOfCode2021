using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay10
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day10example.txt");
            Day10 day = new(input);

            Assert.AreEqual(26397, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day10example.txt");
            Day10 day = new(input);

            Assert.AreEqual(288957, day.SolvePart2());
        }
    }
}