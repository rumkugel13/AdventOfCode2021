using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay08
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day08example.txt");
            Day08 day08= new Day08(input);

            Assert.AreEqual(26, day08.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day08example.txt");
            Day08 day08 = new Day08(input);

            Assert.AreEqual(61229, day08.SolvePart2());
        }
    }
}