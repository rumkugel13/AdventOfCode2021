using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay20
    {
        [TestMethod]
        public void TestPart01()
        {
            Day20 day = new(File.ReadAllLines("day20example.txt"));

            Assert.AreEqual(35, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Day20 day = new(File.ReadAllLines("day20example.txt"));

            Assert.AreEqual(3351, day.SolvePart2());
        }
    }
}