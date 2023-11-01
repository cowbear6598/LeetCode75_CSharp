using NUnit.Framework;

namespace LeetCode75.CanPlaceFlowers
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase(true, new[] { 1, 0, 0, 0, 1 }, 1)]
        [TestCase(false, new[] { 1, 0, 0, 0, 1 }, 2)]
        [TestCase(true, new[] { 0 }, 1)]
        [TestCase(true, new[] { 0, 0, 1, 0, 0 }, 1)]
        public void Should_Correct(bool expected, int[] flowerbed, int n)
        {
            var solution = new Solution();

            var result = solution.CanPlaceFlowers(flowerbed, n);

            Assert.AreEqual(expected, result);
        }
    }
}