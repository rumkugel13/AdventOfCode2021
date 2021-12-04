using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay04
    {
        [TestMethod]
        public void TestPart01()
        {
            string[] input = File.ReadAllLines("day04example.txt");
            Day04 day04 = new Day04();
            day04.Parse(input);

            Assert.AreEqual(4512, day04.SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            string[] input = File.ReadAllLines("day04example.txt");
            Day04 day04 = new Day04();
            day04.Parse(input);

            Assert.AreEqual(1924, day04.SolvePart2());
        }

        [TestMethod]
        public void TestBingo()
        {
            Day04.Board board = new Day04.Board();
            board.board = new System.Collections.Generic.List<int>(System.Linq.Enumerable.Range(0, 25));
            board.marked = new System.Collections.Generic.HashSet<int> { 0, 1, 2, 3, 4 };

            Assert.IsTrue(new Day04().IsBingo(board), "First row should work");

            board.marked = new System.Collections.Generic.HashSet<int> { 0, 5, 10, 15, 20 };

            Assert.IsTrue(new Day04().IsBingo(board), "First col should work");

            board.marked = new System.Collections.Generic.HashSet<int> { 3, 6, 9, 15, 20 };

            Assert.IsFalse(new Day04().IsBingo(board), "Random should not work");

            board.marked = new System.Collections.Generic.HashSet<int> { 20, 21, 22, 23, 24 };

            Assert.IsTrue(new Day04().IsBingo(board), "Last row should work");

            board.marked = new System.Collections.Generic.HashSet<int> { 4, 9, 14, 19, 24 };

            Assert.IsTrue(new Day04().IsBingo(board), "Last col should work");
        }
    }
}