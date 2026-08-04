namespace _35_Vowel_Count;

public class Solution
{
    public static int GetVowelCount(string str)
    {
        return str.Count(c => "aeiou".Contains(c));
    }
}