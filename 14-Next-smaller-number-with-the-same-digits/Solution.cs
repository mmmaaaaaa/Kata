namespace _14_Next_smaller_number_with_the_same_digits;

public class Solution
{
    public static long NextSmallerNumber(long n)
    {
        var nums = n.ToString().ToCharArray();
        int i = nums.Length - 2;
        for (; i >= 0; i--)
        {
            if (nums[i] > nums[i + 1])
            {
                break;
            }
        }
        if (i < 0)
        {
            return -1;
        }
        for (int j = nums.Length - 1; j >= 0; j--)
        {
            if (nums[j] < nums[i])
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                break;
            }
        }
        Array.Reverse(nums, i + 1, nums.Length - i- 1 );
        if (nums[0] == '0')
        {
            return -1;
        }
        return long.Parse(new string(nums));
    }
}