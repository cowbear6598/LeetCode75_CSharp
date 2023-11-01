namespace LeetCode75.CanPlaceFlowers
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var prev = 0;
            var next = 0;

            for (var i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0)
                {
                    return true;
                }

                if (i != flowerbed.Length - 1)
                {
                    next = flowerbed[i + 1];
                }

                if (prev == 0 && next == 0 && flowerbed[i] == 0)
                {
                    n--;
                    flowerbed[i] = 1;
                }

                prev = flowerbed[i];
            }

            return n == 0;
        }
        
        // public bool CanPlaceFlowers(int[] flowerbed, int n)
        // {
        //     for (var i = 0; i < flowerbed.Length; i++)
        //     {
        //         if (n == 0)
        //         {
        //             return true;
        //         }
        //
        //         if (flowerbed[i] == 1)
        //         {
        //             continue;
        //         }
        //
        //         if (flowerbed.Length == 1)
        //         {
        //             PlaceFlower(ref flowerbed, ref n, i);
        //             continue;
        //         }
        //
        //         if (CanPlace(flowerbed, i + 1) && CanPlace(flowerbed, i - 1))
        //         {
        //             PlaceFlower(ref flowerbed, ref n, i);
        //         }
        //     }
        //
        //     return n == 0;
        // }
        //
        // private void PlaceFlower(ref int[] flowerbed, ref int n, int i)
        // {
        //     flowerbed[i] = 1;
        //     n--;
        // }
        //
        // private bool CanPlace(int[] flowerbed, int i)
        // {
        //     try
        //     {
        //         return flowerbed[i] == 0;
        //     }
        //     catch (Exception e)
        //     {
        //         return true;
        //     }
        // }
    }
}