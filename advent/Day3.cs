﻿using System.Collections.Generic;
using System.Linq;

namespace advent
{
	class Day3
	{
		public static void Challenge1()
		{
			var result = GetTrees(inputMap, 3, 1);
		}

		public static void Challenge2()
		{
			decimal answer = GetTrees(inputMap, 1, 1);
			answer *= GetTrees(inputMap, 3, 1);
			answer *= GetTrees(inputMap, 5, 1);
			answer *= GetTrees(inputMap, 7, 1);
			answer *= GetTrees(inputMap, 1, 2);
		}

		public static int GetTrees(IEnumerable<string> map, int run, int rise)
		{
			int lineCount = map.Count();

			int width = map.First().Length;
			int treeCount = 0;
			int position = 0;
			for (int i = 0; i < lineCount; i += rise)
			{
				string line = map.ElementAt(i);
				if (line.ElementAt(position) == '#')
				{
					treeCount++;
				}
				position = (position + run) % width;
			}
			return treeCount;
		}

		public static readonly List<string> inputMap = new List<string>() {
			"...#...#..#....#..#...#..##..#.",
			".#..#.....#.#............###...",
			".#...###....#.............##..#",
			"...##...##....#.....##..#.##...",
			".....###.#.###..##.#.##.......#",
			"#...##.....#..........#..#.#.#.",
			"......##.......##..#....#.#....",
			"....#.###.##..#.#..##.##....#.#",
			".......#.......###.#.#.##.....#",
			".........#.#....#..........#.#.",
			".#...##.....##.........#..#....",
			".##....#.#.#...##......#.......",
			"##.#.#..#....#....#....#...#.#.",
			"##....#.#..##......#....##...#.",
			"....#..#..##..#.###.......#.#..",
			".....##....###...........#.#.##",
			"#.....##.........#....##......#",
			"........###.#..#....#....#.....",
			"...#.......#.##..#.###......#..",
			"...............#..#....#.##....",
			"..#..###..#.#..#.........##..#.",
			"####..#..####..................",
			"#...####...#.......#.#.#...#...",
			"......###.....#......#..#..#...",
			"#...#.....##.....#.#..##...#.#.",
			"#...........##.......#.........",
			".#..#.........#.#..##....#.....",
			"........##...#................#",
			"........#.###.#.###.#.#.##..##.",
			".#....##.....#...##.#..#.#.....",
			"..#..#.....###....##.#....#.#.#",
			"#......##.##...##..#.........#.",
			"#..#..#.....#.....#.........#..",
			"#....#.#...###.........#...#...",
			".#.#.....##......#.#......#....",
			"..##......##...#.#.#.#.........",
			"..#......#.....##.###.#.#..#...",
			"....#..#.......#..#..#.....#...",
			".#.#.....#...#..........#......",
			"#.#..#...........#.#.##.#...#.#",
			"..#.#....###...#...#.....#.#...",
			"....##.#.###....####.......#...",
			".....##....#.......#..#..#....#",
			"...##..#.#.#.#......#......#...",
			"...##...#....#...#......###...#",
			"........#..#.#.....#.###.......",
			"..#..##.#....#.#.........#...#.",
			".....#.####....#.##.........#..",
			"......#...#...#.....#......###.",
			".##.....#....#..#.#....#.....#.",
			"...........#...#....##..#...#..",
			".....#....#.....#...##..#...#.#",
			".#...#.........#.......#...#..#",
			"...#..#...#........#......#....",
			"..#..#####.#.....#.#....#...#.#",
			"...#.......#.#....#...##..#..#.",
			"####..#.#.###.#.#..............",
			".##........#...#.#....#..#.....",
			"..#..............#.#..##...#.##",
			".###.#.....#.#.....##.#......##",
			"....###.....#...#...#.#..#.....",
			"....###.#.##.......#....#...#..",
			"#..#...#......##..#.....#.#...#",
			"....#.#.........#..............",
			"#.##.##...#..#.#.#.....#...#.##",
			"#...#...#......#...........##..",
			"#.#.#......#............#.#....",
			".#.#..######...#.#.........#.##",
			"..#.#..#...#......#............",
			"....#.....#......##..#.....#...",
			".##............#....##..#......",
			".#.#.#...#.##.............###.#",
			"#.#...#...#.....#....#.#.#.....",
			"........#..#......##.##.#.....#",
			".....#.....#.#####...#....#....",
			".#...#......#.........#.#......",
			"...#...#..##.....##....#..#....",
			"....#....##..#.........#.......",
			"..#........##..#.#........#....",
			"...#...##...........#...#....#.",
			".....##.........#..#....#..#.#.",
			"#..#....##..#...##.....#..##.#.",
			"..#.#.#.#...#...#.....#.#....#.",
			".......#.###...#.#.......#.#...",
			"....#..#..#.###.#.....###..#.#.",
			".#..##......#..#..#....#.####..",
			"..##...........#...#.........#.",
			"......#..#...#..........#......",
			"....#..........#......##...#...",
			"....#..#.##........#.#...##.#..",
			"#.##......#........##.#...#...#",
			"#..#....#.....###........##....",
			"...........##.....##..#....#.##",
			"..#....#..#..#......#.#.....#..",
			"#....#.##....#.....##.......#..",
			".#.....#.#..............#.##..#",
			".#..#..#...#...#....#.#.....#..",
			"...###...##.#...#..#........#..",
			"#...#.##.#.....#.#....#..#.....",
			"#.....###.#.......#.#..#.#..##.",
			"....#..#..##.......###.#...#...",
			".#...####...............#.....#",
			".#.##.#.....#.....#.#......##.#",
			"#...........#.##....###.##....#",
			"...............#..........#....",
			".....#..#.##.###.#.............",
			"...##.............#.....#.#..#.",
			"....#.#...#.#..#..#..#....#....",
			"..#.......#..........#...#...#.",
			"...............#.#.#...###....#",
			"....#...#.##....#..##....#.....",
			"........#.#.##.........##.##.##",
			"#.....###.......#.#....#..#..##",
			".#..#...#......#.#..##.......#.",
			"#.....#.#........#.##..#..#....",
			".###..##.#.......#......###....",
			".#...###.....#.....#....###...#",
			"........##.##......#.#....#...#",
			".#....#..#.........#..##...##..",
			".......#.......##.#..#..##.....",
			"#..##..##......#.#......#.##...",
			"..#..###..#...#....#..#...#....",
			"#.............#.####.........##",
			"..#..................#...#..#..",
			"..#......#........##.......#.#.",
			".#.#.#.#..###.....#....#.#.....",
			"...#.##.###.......#....#.......",
			"................##...#.....#...",
			"..#.###.#...#.####....#..#..#..",
			"..#....###....##..#.#.........#",
			".#..#.#.....#........#....##...",
			".....#..#......#..#..##.#.#....",
			".#..#.........##....##......#..",
			".....#.#...#...#.#...#.#...#.#.",
			"..#..#...#...#...##.#..###.....",
			"..#..##......#..##.#...##......",
			".......#..##....##.#......#..#.",
			"..#......#.#.....#.##....##....",
			"..#....#......#......##........",
			"....##.#.#....#.......#.##.....",
			"#.....#...###....#....#...#....",
			"............#.#..#...#...#..#..",
			"..##.............##....#.......",
			".#.......#.##.#......#....##...",
			"...##............#....#..#...#.",
			".##.####.....#.#..###.#....#.##",
			"....##.#........#..#...#.......",
			"...#...###.##...........##..#..",
			"..##..##....#...#..#..........#",
			"..#.........#.#...##..........#",
			".......##....#.#...##.....#..#.",
			".............#.....#.#.......#.",
			"#.......#..##..##...##.#.......",
			"..............#.....#.#..#...##",
			"........##..#.....#...#...#.#..",
			"###.#.................#........",
			"...#........#...#.#######..#..#",
			"...#.##...##.#.#..######...#...",
			"#.......#..#....#..#.##.....#..",
			"#..#....##....#.##.......#....#",
			"#...#..#.#.#...#..#.##..#......",
			"....#..##....#..#.#...........#",
			".##..#.#.............###.......",
			"#....##......#..#..#.....###...",
			"..#..........#...###.#.........",
			".####......#....#......#.#....#",
			"..#....#.#.#......#....#.......",
			".....#.....#....#....#####....#",
			".##..........#...#.###....#....",
			"....##.....##......#...#.#.....",
			".#...#...#..#.#.#...#####......",
			"...#.##..####.##.##.......##...",
			"............#.......#..........",
			".#..##.#..#####........#..#...#",
			"#......##..##..##.........##...",
			"....#....#.............#.#....#",
			"###..#.....#.....#.#...#..#.###",
			"#...#.......##......#....#.#.#.",
			"...#......#..#...#....#...###.#",
			"....#....##.......#....#......#",
			"............#......##.##.....#.",
			"...#.........#......#....##..##",
			".....##....##...#..###...#..#..",
			".......##.#..........#.##.##...",
			"....##...........#.#..#..#.##.#",
			"#...#..##.##.#....#....#.#.....",
			"...##.#.....#..#..#..###....##.",
			"#.##.#..#..#.#.............#...",
			"..#.#.............###.....#....",
			"...#..#....#..#.....#.#..#..#..",
			"...#.....##.#...........#..##.#",
			".........#.#.##..#..#.#...#....",
			"...#..##..#...#...###.##.#..#..",
			".#..##...##......##..##........",
			"......##....##.#.##.#.#........",
			"...#..................#.....#..",
			".##................#.#..#..###.",
			".##.##.....#................#..",
			".....#.#..........#...#..#.#..#",
			".............#......#..#.#..#..",
			"...#...##..#........#....#.....",
			"#......#........##.##...##.....",
			"##..#..##....#...#............#",
			"..##..##.##....##..##........#.",
			"...#....#.#.#.#....#.#...##....",
			"....#...##..##.#.##...#..#...#.",
			"#..#....##.#.....#.......#...##",
			"##.#....#.............#..#.....",
			".##..#..#.#.....#.......#.#..#.",
			".......#..#...##...#...###..#..",
			"..........#...#.#..##.....#...#",
			"..#....#...........#####....#..",
			"#....#..#.......##.............",
			".........##..#####.......##....",
			"#..#..........#.....###...#..#.",
			".#.#.#..#...#.......##...#####.",
			".....#....#.###...#.......#....",
			"#.#.....##...###....###....#...",
			".#.....#..#.#.#........#...#...",
			".##.#.#.#......#....###....#...",
			".#..##..####......###......#...",
			"......#.#.#.#.#...#...####.##..",
			".#........##..#.....#....#....#",
			".....###......##..#....#.......",
			"#.#.##...#.#......###..........",
			"........#.#...#..#......#....#.",
			"..##...##.........#.......#.#..",
			"..#.##....#...##.....#.###.....",
			".........#..#.#....#....#.#.##.",
			"#.........#......#..#.......#..",
			"...#...##.......#.........#....",
			"............#......#...........",
			"##.....#.....#.#...#.....#.....",
			"..#.#...#..#...#.#...........#.",
			"#.#.#..#..#...##.#...#.#.....#.",
			".#..###.#..##.#.....#.....#....",
			"##....##....#.......##..##.....",
			".#..#...........###..........#.",
			".#..#..#..........###..#.......",
			"#..###......#............##...#",
			"#......#........#..#..#..#.#...",
			".......#.###...#.##............",
			".##....#.......#.#...##.....#.#",
			"....#..#.#.......#.#...........",
			"##....#.###.#....#.#..##.#....#",
			"..#..#..#....#...#........##...",
			"...#...##....#..#.#...#..#.....",
			"......#..#......#....#.......#.",
			"#.#..............#...###...#..#",
			"...#....#..#..........#.#...#..",
			"#.....##..##.....#........#....",
			".#...##..#.#..............#....",
			"##.#....#..##...#..#.####.#..#.",
			".....#.......#.#.#.#..#.....###",
			"...#.##....#.#........##.......",
			"#...#.#...#.#..###..##.##...#.#",
			"###..............#.#.###.......",
			"...###..#.#..#....##...###.#...",
			"......##...........#...#..#...#",
			".#..#.........##.......#..#...#",
			".#.......###......##...#...#...",
			".#......##...#........#.......#",
			".#..#.....#.........#.#........",
			"#...#.#.....#...#..##.........#",
			"......##.#......##.#..##.#.....",
			"...............#.#..#....#....#",
			"#....#..#..#..#.#.....##...##..",
			"#.#......#.###......#..#...####",
			".#.#..#...#...#.#..#.##.##.#.#.",
			".....#.#...###...#.#.....##....",
			"...#..#.#..........##.#....#.#.",
			"...#..#.#.##.....###.##.#....#.",
			"..........#..###......#..#.#...",
			"###.....#..###..#...#..###.#...",
			"..#..#.....##.#.#..###.......#.",
			"....#....##........##..........",
			".......#..........#...#......#.",
			".#........#.#.#.#.#.......#....",
			".#..#.......##..##....#.#...#..",
			".#.#.#.......#..#..............",
			"#.#....#.#...#.#.#.....#.#...##",
			".....#..........##..#.......#..",
			".##......#.#....#.#.......#....",
			"..#.##....#.##.#...#...........",
			"...##......##..##.............#",
			"..........##.#.#..#..........#.",
			".##....#..#..#.#....##.#...#.#.",
			"...........#....#.....#.#..#...",
			".#.....#....##..#.........#....",
			".....#.....#...#....#...#.###.#",
			"..#....#....#.....#...#......#.",
			".....##..#.............#...#...",
			"........#..#.......#.#.......#.",
			"#...###..#.##.#...###...##..##.",
			"....##..#.......#...#.#........",
			".#...#.#.##....####........#..#",
			".#...#.#.####.##.#.............",
			"#..##...#....#...#.#.#.#.##..#.",
			".#.......#........#.....###....",
			"#.#.....#....#..#....#..#....#.",
			"...#..#...#.....#.........##...",
			".#....#......###...#....#.#.#..",
			"#.#........#......#...#....##..",
			".....#..#......#..#..#......#..",
			".#.....#..#.##.#.#.#...#......#",
			"##........#..#.#..#...#.####...",
			"..........##....#.#..#.#....#..",
			"#.##..#..#....#..#....##..#.#.#",
			"..#......#.......#...##..#.....",
			"##...#.........#......#......#.",
			".#.....................#..#.##.",
			".#.......#........#.#.#..##.#..",
			"..#..........#........#..##.#..",
			".#...#...#.........##.#.#.#....",
			"....#....#.###.#....###....#.##",
			"....##......##........##.#.##..",
			"....#.#......#.##.#...#.##.....",
			"....#....#..#.#..###.#.#.......",
			"....#......#..#.#.......#..##..",
			".....#..#.#.##.##..##.....#.#..",
			"...#....................##.....",
			"#.....#...##...#.#.............",
			"..#.#...#.#.#.....##..#....#..."
		};
	}
}
