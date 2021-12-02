using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay02
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day02example.txt");

            Assert.AreEqual(150, Day02.SolvePart1(Utils.ToCommands(input)));
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day02example.txt");

            Assert.AreEqual(900, Day02.SolvePart2(Utils.ToCommands(input)));
        }
    }
}