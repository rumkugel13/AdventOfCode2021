using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay03
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day03example.txt");

            Assert.AreEqual(198, Day03.SolvePart1(Utils.ToCharArray(input)));
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day03example.txt");

            Assert.AreEqual(230, Day03.SolvePart2(Utils.ToCharArray(input)));
        }
    }
}