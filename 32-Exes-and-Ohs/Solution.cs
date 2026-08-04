namespace _32_Exes_and_Ohs;

public class Solution
{
    public static bool XO (string input)
    {
        var lower = input.ToLower();
        var x_count = lower.Count(c => c == 'x');
        var o_count = lower.Count(c => c == 'o');
        return x_count == o_count;
    }
}