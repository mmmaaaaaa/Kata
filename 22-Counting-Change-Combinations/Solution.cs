namespace _22_Counting_Change_Combinations;

public class Solution
{
    public static int CountCombinations(int money, int[] coins)
    {
        var dp = new int[money + 1];
        dp[0] = 1;
        foreach (var coin in coins)
        {
            for (int j = coin; j <= money; j++)
            {
                dp[j] += dp[j - coin];
            }
        }
        return dp[money];
    }
}