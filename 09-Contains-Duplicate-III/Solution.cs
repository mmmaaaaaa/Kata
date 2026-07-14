namespace _09_Contains_Duplicate_III;

public class Solution {
    public static bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        var dict = new Dictionary<long, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var bucketNum = (long)Math.Floor((double)nums[i] / (valueDiff + 1));
            if (dict.ContainsKey(bucketNum))
            {
                return true;
            }
            if (dict.ContainsKey(bucketNum - 1) && Math.Abs(nums[i] - dict[bucketNum - 1]) <= valueDiff)
            {
                return true;
            }
            if (dict.ContainsKey(bucketNum + 1) && Math.Abs(nums[i] - dict[bucketNum + 1]) <= valueDiff)
            {
                return true;
            } 
            if (i >= indexDiff)
            {
                var oldBucketNum = (long)Math.Floor((double)nums[i - indexDiff] / (valueDiff + 1));
                dict.Remove(oldBucketNum);
            }
            dict[bucketNum] = nums[i];
        }
        return false;
    }
}