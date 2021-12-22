using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay22
    {
        [TestMethod]
        public void TestPart01()
        {
            Day22 day = new(File.ReadAllLines("day22example.txt"));

            Assert.AreEqual(590784, day.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Day22 day = new(File.ReadAllLines("day22example.txt"));

            Assert.AreEqual(0, day.SolvePart2());
        }
    }
}