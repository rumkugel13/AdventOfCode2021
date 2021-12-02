// See https://aka.ms/new-console-template for more information
using AdventOfCode2021;

Console.WriteLine("AdventOfCode2021");

string[] input = File.ReadAllLines("day01.txt");

Console.WriteLine("Day 01 Part 1: " + Day01.SolvePart1(Utils.ToIntArray(input)));
Console.WriteLine("Day 01 Part 2: " + Day01.SolvePart2(Utils.ToIntArray(input)));

input = File.ReadAllLines("day02.txt");

Console.WriteLine("Day 02 Part 1: " + Day02.SolvePart1(Utils.ToCommands(input)));
Console.WriteLine("Day 02 Part 2: " + Day02.SolvePart2(Utils.ToCommands(input)));