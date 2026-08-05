namespace _38_Only_one;

public class Solution
{
    public static bool OnlyOne(params bool[] flags)
    {
        return flags.Count(t => t) == 1;
    }
}