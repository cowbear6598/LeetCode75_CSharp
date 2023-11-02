using NUnit.Framework;

namespace LeetCode75.ReverseWordsInAString
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase("blue is sky the", "the sky is blue")]
        [TestCase("world hello", "  hello world  ")]
        [TestCase("example good a", "a good   example")]
        public void Should_Correct(string expected, string s)
        {
            Solution solution = new Solution();

            string result = solution.ReverseWords(s);

            Assert.AreEqual(expected, result);
        }
    }
}