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
Day04 day04 = new Day04(input);

Console.WriteLine("Day 04 Part 1: " + day04.SolvePart1());
Console.WriteLine("Day 04 Part 2: " + day04.SolvePart2());

input = File.ReadAllLines("day05.txt");
Day05 day05 = new Day05(input);

Console.WriteLine("Day 05 Part 1: " + day05.SolvePart1());
Console.WriteLine("Day 05 Part 2: " + day05.SolvePart2());

input = File.ReadAllLines("day06.txt");
Day06 day06 = new Day06(input);

Console.WriteLine("Day 06 Part 1: " + day06.SolvePart1());
Console.WriteLine("Day 06 Part 2: " + day06.SolvePart2());

input = File.ReadAllLines("day07.txt");
Day07 day07 = new Day07(input);

Console.WriteLine("Day 07 Part 1: " + day07.SolvePart1());
Console.WriteLine("Day 07 Part 2: " + day07.SolvePart2());

input = File.ReadAllLines("day08.txt");
Day08 day08 = new Day08(input);

Console.WriteLine("Day 08 Part 1: " + day08.SolvePart1());
Console.WriteLine("Day 08 Part 2: " + day08.SolvePart2());

input = File.ReadAllLines("day09.txt");
Day09 day09 = new Day09(input);

Console.WriteLine("Day 09 Part 1: " + day09.SolvePart1());
Console.WriteLine("Day 09 Part 2: " + day09.SolvePart2());

input = File.ReadAllLines("day10.txt");
Day10 day10 = new Day10(input);

Console.WriteLine("Day 10 Part 1: " + day10.SolvePart1());
Console.WriteLine("Day 10 Part 2: " + day10.SolvePart2());

input = File.ReadAllLines("day11.txt");
Day11 day11 = new(input);

Console.WriteLine("Day 11 Part 1: " + day11.SolvePart1());
Console.WriteLine("Day 11 Part 2: " + day11.SolvePart2());
