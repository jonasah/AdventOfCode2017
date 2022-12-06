using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017
{
    public static class Util
    {
        public static void WriteResult(int day, int part, object answer)
        {
            Console.WriteLine($"Day {day}, part {part}: {answer}");
        }
    }

    public static class Extensions
    {
        public static string Join(this IEnumerable<char> chars, string separator)
        {
            return string.Join(separator, chars);
        }
    }
}
