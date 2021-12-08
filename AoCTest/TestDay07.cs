using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay07
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day07example.txt");
            Day07 day07= new Day07(input);

            Assert.AreEqual(37, day07.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day07example.txt");
            Day07 day07 = new Day07(input);

            Assert.AreEqual(168, day07.SolvePart2());
        }
    }
}