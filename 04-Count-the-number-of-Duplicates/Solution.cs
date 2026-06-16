public class Solution
{
    public static int GetDuplicatesNumber(string word)
    {
        word = word.ToLower();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(var i in word)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]++;  
            }
            else
            {
                dict[i] = 1;
            }
        }
        return dict.Count(x => x.Value > 1);
    }
}