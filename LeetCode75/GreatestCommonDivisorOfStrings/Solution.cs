namespace LeetCode75.GreatestCommonDivisorOfStrings
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            // This is not my solution, my solution got a bad grade, so I replace from other's solution
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }

            var a = str1.Length;
            var b = str2.Length;

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return str1.Substring(0, a);
        }
    }
}