using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay06
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day06example.txt");
            Day06 day06= new Day06(input);

            Assert.AreEqual(5934, day06.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day06example.txt");
            Day06 day06 = new Day06(input);

            Assert.AreEqual(26984457539, day06.SolvePart2());
        }
    }
}