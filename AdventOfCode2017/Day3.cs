using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017
{
    public static class Day3
    {
        private static readonly int PuzzleInput = 312051;

        public static void SolvePart1()
        {
            Util.WriteResult(3, 1, CalculatePart1(PuzzleInput));
        }

        //public static void SolvePart2()
        //{
        //    Util.WriteResult(3, 2, CalculatePart2(PuzzleInput));
        //}

        public static int CalculatePart1(int input)
        {
            throw new NotImplementedException();

            if (input == 1)
            {
                return 0;
            }

            var layer = 1;

            Func<int, int> square = i => i * i;

            while (input > square(2 * layer - 1))
            {
                ++layer;
            }

            return layer;
        }
    }
}
