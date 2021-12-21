using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay21
    {
        [TestMethod]
        public void TestPart01()
        {
            Day21 day = new(File.ReadAllLines("day21example.txt"));

            Assert.AreEqual(739785, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Day21 day = new(File.ReadAllLines("day21example.txt"));

            Assert.AreEqual(0, day.SolvePart2());
        }
    }
}