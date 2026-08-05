namespace _36_Find_The_Parity_Outlier;

public class Solution
{
    public static int Find(int[] integers)
    {
        var even_count = integers.Count(x => x % 2 == 0);
        var odd_count = integers.Count(x => x % 2 != 0);
        if (odd_count < even_count)
        {
            return integers.First(x => x % 2 != 0);
        }
        return integers.First(x => x % 2 == 0);
    }
}