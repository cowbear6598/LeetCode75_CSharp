using System.Text;

namespace LeetCode75.ReverseWordsInAString
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ');

            var result = new StringBuilder();

            for (var i = words.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(words[i]))
                {
                    continue;
                }

                result.Append(words[i]);

                if (i != 0)
                {
                    result.Append(" ");
                }
            }

            if (result[result.Length - 1] == ' ')
            {
                result.Remove(result.Length - 1, 1);
            }

            return result.ToString();
        }
    }
}