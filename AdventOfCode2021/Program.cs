// See https://aka.ms/new-console-template for more information
using AdventOfCode2021;

Console.WriteLine("AdventOfCode2021");

string[] input = File.ReadAllLines("input/day01.txt");

Console.WriteLine("Day 01 Part 1: " + Day01.SolvePart1(Utils.ToIntArray(input)));
Console.WriteLine("Day 01 Part 2: " + Day01.SolvePart2(Utils.ToIntArray(input)));

input = File.ReadAllLines("input/day02.txt");

Console.WriteLine("Day 02 Part 1: " + Day02.SolvePart1(Utils.ToCommands(input)));
Console.WriteLine("Day 02 Part 2: " + Day02.SolvePart2(Utils.ToCommands(input)));

input = File.ReadAllLines("input/day03.txt");

Console.WriteLine("Day 03 Part 1: " + Day03.SolvePart1(Utils.ToCharArray(input)));
Console.WriteLine("Day 03 Part 2: " + Day03.SolvePart2(Utils.ToCharArray(input)));

input = File.ReadAllLines("input/day04.txt");
Day04 day04 = new Day04(input);

Console.WriteLine("Day 04 Part 1: " + day04.SolvePart1());
Console.WriteLine("Day 04 Part 2: " + day04.SolvePart2());

input = File.ReadAllLines("input/day05.txt");
Day05 day05 = new Day05(input);

Console.WriteLine("Day 05 Part 1: " + day05.SolvePart1());
Console.WriteLine("Day 05 Part 2: " + day05.SolvePart2());

input = File.ReadAllLines("input/day06.txt");
Day06 day06 = new Day06(input);

Console.WriteLine("Day 06 Part 1: " + day06.SolvePart1());
Console.WriteLine("Day 06 Part 2: " + day06.SolvePart2());

input = File.ReadAllLines("input/day07.txt");
Day07 day07 = new Day07(input);

Console.WriteLine("Day 07 Part 1: " + day07.SolvePart1());
Console.WriteLine("Day 07 Part 2: " + day07.SolvePart2());

input = File.ReadAllLines("input/day08.txt");
Day08 day08 = new Day08(input);

Console.WriteLine("Day 08 Part 1: " + day08.SolvePart1());
Console.WriteLine("Day 08 Part 2: " + day08.SolvePart2());

input = File.ReadAllLines("input/day09.txt");
Day09 day09 = new Day09(input);

Console.WriteLine("Day 09 Part 1: " + day09.SolvePart1());
Console.WriteLine("Day 09 Part 2: " + day09.SolvePart2());

input = File.ReadAllLines("input/day10.txt");
Day10 day10 = new Day10(input);

Console.WriteLine("Day 10 Part 1: " + day10.SolvePart1());
Console.WriteLine("Day 10 Part 2: " + day10.SolvePart2());

input = File.ReadAllLines("input/day11.txt");
Day11 day11 = new(input);

Console.WriteLine("Day 11 Part 1: " + day11.SolvePart1());
Console.WriteLine("Day 11 Part 2: " + day11.SolvePart2());

//Day12 day12 = new(File.ReadAllLines("input/day12.txt"));

//Console.WriteLine("Day 12 Part 1: " + day12.SolvePart1());
//Console.WriteLine("Day 12 Part 2: " + day12.SolvePart2());

Day13 day13 = new(File.ReadAllLines("input/day13.txt"));

Console.WriteLine("Day 13 Part 1: " + day13.SolvePart1());
//Console.WriteLine("Day 13 Part 2: " + day13.SolvePart2());
day13.SolvePart2();

Day14 day14 = new(File.ReadAllLines("input/day14.txt"));

Console.WriteLine("Day 14 Part 1: " + day14.SolvePart1());
Console.WriteLine("Day 14 Part 2: " + day14.SolvePart2());

//Day15 day15 = new(File.ReadAllLines("input/day15.txt"));

//Console.WriteLine("Day 15 Part 1: " + day15.SolvePart1());
//Console.WriteLine("Day 15 Part 2: " + day15.SolvePart2());

Day16 day16 = new(File.ReadAllLines("input/day16.txt"));

Console.WriteLine("Day 16 Part 1: " + day16.SolvePart1());
Console.WriteLine("Day 16 Part 2: " + day16.SolvePart2());

//Day17 day17 = new(File.ReadAllLines("input/day17.txt"));

//Console.WriteLine("Day 17 Part 1: " + day17.SolvePart1());
//Console.WriteLine("Day 17 Part 2: " + day17.SolvePart2());

//Day18 day18 = new(File.ReadAllLines("input/day18.txt"));

//Console.WriteLine("Day 18 Part 1: " + day18.SolvePart1());
//Console.WriteLine("Day 18 Part 2: " + day18.SolvePart2());

//Day19 day19 = new(File.ReadAllLines("input/day19.txt"));

//Console.WriteLine("Day 19 Part 1: " + day19.SolvePart1());
//Console.WriteLine("Day 19 Part 2: " + day19.SolvePart2());

Day20 day20 = new(File.ReadAllLines("input/day20.txt"));

Console.WriteLine("Day 20 Part 1: " + day20.SolvePart1());
Console.WriteLine("Day 20 Part 2: " /*+ day20.SolvePart2()*/);

Day21 day21 = new(File.ReadAllLines("input/day21.txt"));

Console.WriteLine("Day 21 Part 1: " + day21.SolvePart1());
Console.WriteLine("Day 21 Part 2: " + day21.SolvePart2());

Day22 day22 = new(File.ReadAllLines("input/day22.txt"));

Console.WriteLine("Day 22 Part 1: " + day22.SolvePart1());
Console.WriteLine("Day 22 Part 2: " + day22.SolvePart2());

//Day23 day23 = new(File.ReadAllLines("input/day23.txt"));

//Console.WriteLine("Day 23 Part 1: " + day23.SolvePart1());
//Console.WriteLine("Day 23 Part 2: " + day23.SolvePart2());

Day24 day24 = new(File.ReadAllLines("input/day24.txt"));

//Console.WriteLine("Day 24 Part 1: " + day24.SolvePart1());
Console.WriteLine("Day 24 Part 2: " + day24.SolvePart2());

Day25 day25 = new(File.ReadAllLines("input/day25.txt"));

Console.WriteLine("Day 25 Part 1: " + day25.SolvePart1());
Console.WriteLine("Day 25 Part 2: " + day25.SolvePart2());