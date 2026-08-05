namespace _36_Find_The_Parity_Outlier;

public class Solution
{
    public static int Find(int[] integers)
    {
        var odd_count = 0;
        var even_count = 0;
        for (int i = 0; i < integers.Length; i++)
        {
            if (integers[i] % 2 == 0)
            {
                even_count++;
            }
            else
            {
                odd_count++;
            }
        }
        if (odd_count < even_count)
        {
            return integers.First(x => x % 2 != 0);
        }
        return integers.First(x => x % 2 == 0);
    }
}