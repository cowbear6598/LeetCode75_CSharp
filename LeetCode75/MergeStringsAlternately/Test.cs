using NUnit.Framework;

namespace LeetCode75.MergeStringsAlternately
{
    public class Test
    {
        [Test]
        [TestCase("apbqcr", "abc", "pqr")]
        [TestCase("apbqrs", "ab", "pqrs")]
        [TestCase("apbqcd", "abcd", "pq")]
        public void Should_Correct(string expected, string word1, string word2)
        {
            var solution = new Solution();

            var result = solution.MergeAlternately(word1, word2);

            Assert.AreEqual(expected, result);
        }
    }
}