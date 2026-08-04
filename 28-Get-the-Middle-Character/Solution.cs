namespace _28_Get_the_Middle_Character;

public class Solution
{
    public static string GetMiddle(string s)
    {
        if (s.Length % 2 == 1)
        {
            return s.Substring(s.Length / 2, 1);
        }
        else
        {
            return s.Substring(s.Length / 2 - 1, 2);
        }
    }
}