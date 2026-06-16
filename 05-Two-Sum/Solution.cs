public class Solution
{
    public static int[] GetTwoSumIndices(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            var needed = target - nums[i];
            if(dict.ContainsKey(needed))
            {
                return [dict[needed], i];
            }
            dict[nums[i]] = i;
        }
        return [];
    }
}