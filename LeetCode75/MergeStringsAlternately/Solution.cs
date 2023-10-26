using System.Text;

namespace LeetCode75.MergeStringsAlternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var result       = new StringBuilder();
            var currentIndex = 0;

            for (var i = 0; i < word1.Length; i++)
            {
                currentIndex = i;

                result.Append(word1[i]);

                if (i >= word2.Length)
                {
                    continue;
                }

                result.Append(word2[i]);
            }

            if (currentIndex > word2.Length)
            {
                return result.ToString();
            }

            for (var i = currentIndex + 1; i < word2.Length; i++)
            {
                result.Append(word2[i]);
            }

            return result.ToString();
        }
    }
}