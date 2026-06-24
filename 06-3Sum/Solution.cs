public class Solution {
    public static IList<IList<int>> GetThreeSumTriplets(int[] nums) {
        var result = new List<IList<int>>();
        for(var i = 0; i < nums.Length - 2; i++)
        {
            for(var j = i + 1; j < nums.Length - 1; j++)
            {
                for(var k = j + 1; k < nums.Length; k++)
                {
                    if(nums[i] + nums[j] + nums[k] == 0)
                    {
                        var triplet = new List<int> { nums[i], nums[j], nums[k] };
                        triplet.Sort();
                        if(!result.Any(x => x.SequenceEqual(triplet)))
                        {
                            result.Add(triplet); //如果 result 裡沒有任何一個跟 triplet 完全一樣的，才加入
                        }
                    }
                }
            }
        }

        return result;
    }
}