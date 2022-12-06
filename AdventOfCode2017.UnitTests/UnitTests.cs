using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        /** DAY 1 **/

        [DataTestMethod]
        [DataRow("1122", 3)]
        [DataRow("1111", 4)]
        [DataRow("1234", 0)]
        [DataRow("91212129", 9)]
        public void Day1Part1(string input, int expected)
        {
            Assert.AreEqual(expected, AdventOfCode2017.Day1.CalculatePart1(input));
        }

        [DataTestMethod]
        [DataRow("1212", 6)]
        [DataRow("1221", 0)]
        [DataRow("123425", 4)]
        [DataRow("123123", 12)]
        [DataRow("12131415", 4)]
        public void Day1Part2(string input, int expected)
        {
            Assert.AreEqual(expected, AdventOfCode2017.Day1.CalculatePart2(input));
        }
        
        /** DAY 2 **/

        [TestMethod]
        public void Day2Part1()
        {
            Assert.AreEqual(18, AdventOfCode2017.Day2.CalculatePart1("5 1 9 5\n7 5 3\n2 4 6 8"));
        }

        [TestMethod]
        public void Day2Part2()
        {
            Assert.AreEqual(9, AdventOfCode2017.Day2.CalculatePart2("5 9 2 8\n9 4 7 3\n3 8 6 5"));
        }

        /** DAY 3 **/

        [DataTestMethod]
        [DataRow(1, 0)]
        [DataRow(12, 3)]
        [DataRow(23, 2)]
        [DataRow(1024, 31)]
        public void Day3Part1(int input, int expected)
        {
            Assert.AreEqual(expected, AdventOfCode2017.Day3.CalculatePart1(input));
        }

        /** DAY 4 **/

        [DataTestMethod]
        [DataRow("aa bb cc dd ee", 1)]
        [DataRow("aa bb cc dd aa", 0)]
        [DataRow("aa bb cc dd aaa", 1)]
        public void Day4Part1(string input, int expected)
        {
            Assert.AreEqual(expected, AdventOfCode2017.Day4.CalculatePart1(input));
        }

        [DataTestMethod]
        [DataRow("abcde fghij", 1)]
        [DataRow("abcde xyz ecdab", 0)]
        [DataRow("a ab abc abd abf abj", 1)]
        [DataRow("iiii oiii ooii oooi oooo", 1)]
        [DataRow("oiii ioii iioi iiio", 0)]
        public void Day4Part2(string input, int expected)
        {
            Assert.AreEqual(expected, AdventOfCode2017.Day4.CalculatePart2(input));
        }
    }
}
