// See https://aka.ms/new-console-template for more information
using AdventOfCode2021;

Console.WriteLine("AdventOfCode2021");

string[] input = File.ReadAllLines("day01.txt");

Console.WriteLine("Day 01 Part 1: " + Day01.SolvePart1(Utils.ToIntArray(input)));
Console.WriteLine("Day 01 Part 2: " + Day01.SolvePart2(Utils.ToIntArray(input)));

input = File.ReadAllLines("day02.txt");

Console.WriteLine("Day 02 Part 1: " + Day02.SolvePart1(Utils.ToCommands(input)));
Console.WriteLine("Day 02 Part 2: " + Day02.SolvePart2(Utils.ToCommands(input)));

input = File.ReadAllLines("day03.txt");

Console.WriteLine("Day 03 Part 1: " + Day03.SolvePart1(Utils.ToCharArray(input)));
Console.WriteLine("Day 03 Part 2: " + Day03.SolvePart2(Utils.ToCharArray(input)));

input = File.ReadAllLines("day04.txt");
Day04 day04 = new Day04();
day04.Parse(input);

Console.WriteLine("Day 04 Part 1: " + day04.SolvePart1());
Console.WriteLine("Day 04 Part 2: " + day04.SolvePart2());

input = File.ReadAllLines("day05.txt");
Day05 day05 = new Day05(input);

Console.WriteLine("Day 05 Part 1: " + day05.SolvePart1());
Console.WriteLine("Day 05 Part 2: " + day05.SolvePart2());
