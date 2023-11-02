using NUnit.Framework;

namespace LeetCode75.ReverseVowelsOfAString
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase("holle", "hello")]
        [TestCase("leotcede", "leetcode")]
        public void Should_Correct(string expected, string s)
        {
            Solution solution = new Solution();

            var result = solution.ReverseVowels(s);

            Assert.AreEqual(expected, result);
        }
    }
}