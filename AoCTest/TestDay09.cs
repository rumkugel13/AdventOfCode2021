using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay09
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day09example.txt");
            Day09 day09 = new Day09(input);

            Assert.AreEqual(15, day09.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day09example.txt");
            Day09 day09 = new Day09(input);

            Assert.AreEqual(1134, day09.SolvePart2());
        }
    }
}