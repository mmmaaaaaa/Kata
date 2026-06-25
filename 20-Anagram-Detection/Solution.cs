public class Solution
{
    public static bool IsAnagram(string a, string b)
    {
        var sorteda = new string(a.ToLower().OrderBy(c => c).ToArray());
        var sortedb = new string(b.ToLower().OrderBy(c => c).ToArray());
        if(sorteda == sortedb)
        {
            return true;
        }
        return false;
    }
}