using System.Collections.Generic;
using System.Linq;

namespace LeetCode75.KidsWithTheGreatestNumberOfCandies
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int    greatestNumber = candies.Max();
            bool[] results        = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= greatestNumber)
                {
                    results[i] = true;
                }
            }

            return results;
        }
    }
}