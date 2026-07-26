namespace _15_Play_with_two_Strings;

public class Solution
{
    public static string WorkOnStrings(string a, string b) 
    {
        var aChars = SwapCasing(a.ToCharArray(), b);
        var bChars = SwapCasing(b.ToCharArray(), a);
        return new string(aChars) + new string(bChars);
    }
    private static char[] SwapCasing(char[] chars, string reference)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            int count = reference.Count(c => char.ToLower(c) == char.ToLower(chars[i]));
            if (count % 2 != 0)
            {
                chars[i] = char.IsUpper(chars[i]) ? char.ToLower(chars[i]) : char.ToUpper(chars[i]);
            }
        }
        return chars;
    }
}