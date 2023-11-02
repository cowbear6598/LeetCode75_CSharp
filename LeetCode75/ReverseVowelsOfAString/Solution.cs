using System.Collections;
using System.Linq;
using System.Text;

namespace LeetCode75.ReverseVowelsOfAString
{
    public class Solution
    {
        private char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

        public string ReverseVowels(string s)
        {
            var result = new StringBuilder();
            var stacks = new Stack();

            for (var i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    stacks.Push(s[i]);
                }
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    result.Append(stacks.Pop());
                }
                else
                {
                    result.Append(s[i]);
                }
            }

            return result.ToString();
        }
    }
}