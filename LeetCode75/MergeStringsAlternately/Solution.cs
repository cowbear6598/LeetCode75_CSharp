using System.Text;

namespace LeetCode75.MergeStringsAlternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var result       = new StringBuilder();
            var currentIndex = 0;

            while (currentIndex < word1.Length || currentIndex < word2.Length)
            {
                if (currentIndex < word1.Length)
                {
                    result.Append(word1[currentIndex]);
                }

                if (currentIndex < word2.Length)
                {
                    result.Append(word2[currentIndex]);
                }

                currentIndex++;
            }

            return result.ToString();
        }
    }
}