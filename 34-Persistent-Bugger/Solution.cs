namespace _34_Persistent_Bugger;

public class Solution
{
    public static int Persistence(long n)
    {
        if (n < 10)
        {
            return 0;
        }
        var count = 0;
        while (n >= 10)
        {
            n = n.ToString().Aggregate(1L, (acc, c) => acc * (c - '0'));
            count++;
        } 
        return count;
    }
}