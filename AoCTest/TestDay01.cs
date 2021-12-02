using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay01
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day01example.txt");

            Assert.AreEqual(7, Day01.SolvePart1(Utils.ToIntArray(input)));
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day01example.txt");

            Assert.AreEqual(5, Day01.SolvePart2(Utils.ToIntArray(input)));
        }
    }
}