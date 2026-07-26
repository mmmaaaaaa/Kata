namespace _15_Play_with_two_Strings;

public class Solution
{
    public static string WorkOnStrings(string a, string b) 
    {
        var bChars = b.ToCharArray();
        for (int i = 0; i < bChars.Length; i++)
        {
            int count = a.Count(c => char.ToLower(c) == char.ToLower(bChars[i]));
            if (count % 2 != 0)
            {
                bChars[i] = char.IsUpper(bChars[i]) ? char.ToLower(bChars[i]) : char.ToUpper(bChars[i]);
            }
        }
        var aChars = a.ToCharArray();
        for (int i = 0; i < aChars.Length; i++)
        {
            int count = b.Count(c => char.ToLower(c) == char.ToLower(aChars[i]));
            if (count % 2 != 0)
            {
                aChars[i] = char.IsUpper(aChars[i]) ? char.ToLower(aChars[i]) : char.ToUpper(aChars[i]);
            }
        }
        return new string(aChars) + new string(bChars);
    }
}