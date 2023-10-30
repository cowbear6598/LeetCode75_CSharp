using System.Linq;
using NUnit.Framework;

namespace LeetCode75.KidsWithTheGreatestNumberOfCandies
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase(new[] { true, true, true, false, true }, new[] { 2, 3, 5, 1, 3 }, 3)]
        [TestCase(new[] { true, false, false, false, false }, new[] { 4, 2, 1, 1, 2 }, 1)]
        [TestCase(new[] { true, false, true }, new[] { 12, 1, 12 }, 10)]
        public void Should_Correct(bool[] expected, int[] candies, int extraCandies)
        {
            var solution = new Solution();

            var results = solution.KidsWithCandies(candies, extraCandies).ToArray();

            Assert.AreEqual(expected, results);
        }
    }
}