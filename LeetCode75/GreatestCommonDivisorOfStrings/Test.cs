using NUnit.Framework;

namespace LeetCode75.GreatestCommonDivisorOfStrings
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase("ABC", "ABCABC", "ABC")]
        [TestCase("AB", "ABABAB", "ABAB")]
        [TestCase("", "LEET", "CODE")]
        [TestCase("TAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX")]
        [TestCase("ABAB", "ABABABAB", "ABAB")]
        [TestCase("CXTXN", "CXTXNCXTXNCXTXNCXTXNCXTXN",
                  "CXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXN")]
        public void Should_Correct(string expected, string word1, string word2)
        {
            var solution = new Solution();

            var result = solution.GcdOfStrings(word1, word2);

            Assert.AreEqual(expected, result);
        }
    }
}