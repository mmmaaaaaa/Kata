namespace _18_Compute_the_Largest_Sum_of_all_Contiguous_Subsequences;

public class Solution
{
    public static int LargestSum(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }
        var current_sum = arr[0];
        var max_sum = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            current_sum = Math.Max(arr[i], current_sum + arr[i]);
            max_sum = Math.Max(max_sum, current_sum);
        }
        return max_sum;
    }
}