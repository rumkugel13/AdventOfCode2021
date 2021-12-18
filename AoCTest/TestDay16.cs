using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021;
using System.IO;

namespace AoCTest
{
    [TestClass]
    public class TestDay16
    {
        [TestMethod]
        public void TestPart01()
        {
            //Day16 day = new(File.ReadAllLines("day16example.txt"));
            //Day16 day = new(new string[] { "D2FE28" });   // literal value
            //Day16 day = new(new string[] { "38006F45291200" }); // operator with length
            //Day16 day = new(new string[] { "EE00D40C823060" }); // operator with sub packets

            //Assert.AreEqual(16, day.SolvePart1());

            Assert.AreEqual(16, new Day16(new string[] { "8A004A801A8002F478" }).SolvePart1());
            Assert.AreEqual(12, new Day16(new string[] { "620080001611562C8802118E34" }).SolvePart1());
            Assert.AreEqual(23, new Day16(new string[] { "C0015000016115A2E0802F182340" }).SolvePart1());
            Assert.AreEqual(31, new Day16(new string[] { "A0016C880162017C3686B18A3D4780" }).SolvePart1());
        }

        [TestMethod]
        public void TestPart02()
        {
            Assert.AreEqual(3, new Day16(new string[] { "C200B40A82" }).SolvePart2(), "Failed sum"); // sum
            Assert.AreEqual(54, new Day16(new string[] { "04005AC33890" }).SolvePart2(), "Failed product"); // product
            Assert.AreEqual(7, new Day16(new string[] { "880086C3E88112" }).SolvePart2(), "Failed min"); // min
            Assert.AreEqual(9, new Day16(new string[] { "CE00C43D881120" }).SolvePart2(), "Failed max"); // max
            Assert.AreEqual(1, new Day16(new string[] { "D8005AC2A8F0" }).SolvePart2(), "Failed less than"); // less than
            Assert.AreEqual(0, new Day16(new string[] { "F600BC2D8F" }).SolvePart2(), "Failed greater than"); // greater than
            Assert.AreEqual(0, new Day16(new string[] { "9C005AC2F8F0" }).SolvePart2(), "Failed equal"); // equal
            Assert.AreEqual(1, new Day16(new string[] { "9C0141080250320F1802104A08" }).SolvePart2(), "Failed example"); // example
        }
    }
}