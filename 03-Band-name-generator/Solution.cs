public class Solution
{
    public static string GetBandName(string word)
    {
        var bandName = char.ToUpper(word[0]) + word.Substring(1);
        if(word[0] == word[word.Length - 1])
        {
            return bandName + word.Substring(1);
        }
        else
        {
            return $"The {bandName}" ;
        }
        
    }
}