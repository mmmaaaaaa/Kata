public class Solution
{
    public static int GetDuplicatesNumber(string word)
    {
        word = word.ToLower();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < word.Length; i++)
        {
            if(dict.ContainsKey(word[i]))
            {
                dict[word[i]]++;  
            }
            else
            {
                dict[word[i]] = 1;
            }
        }
        var count = 0;
        foreach(var item in dict)
        {
            if(item.Value > 1) 
            {
                count++;
            }
        }
        return count;
    }
}