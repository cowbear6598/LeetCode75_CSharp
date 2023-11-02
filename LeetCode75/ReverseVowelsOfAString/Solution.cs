using System;
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
            result.EnsureCapacity(s.Length);

            var b = s.Length - 1;

            for (var i = 0; i < s.Length; i++)
            {
                var currentValue = s[i];


                if (!vowels.Contains(currentValue) || b == 0 || i >= b)
                {
                    result.Append(currentValue);
                    continue;
                }

                for (var j = b; j >= 0; j--)
                {
                    var reverseValue = s[j];

                    if (!vowels.Contains(reverseValue) || j < i)
                        continue;

                    result.Append(reverseValue);
                    b = j - 1;
                    break;
                }
            }

            return result.ToString();
        }
    }
}