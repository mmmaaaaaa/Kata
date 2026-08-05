namespace _27_Highest_Rank_Number_in_an_Array;

public class Solution
{
    public static int HighestRank(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(var i in arr)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]++;  
            }
            else
            {
                dict[i] = 1;
            }
        }
        var maxCount = dict.Max(x => x.Value);
        return dict.Where(x => x.Value == maxCount).Max(x => x.Key);
    }
}