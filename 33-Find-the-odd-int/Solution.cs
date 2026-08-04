namespace _33_Find_the_odd_int;

public class Solution
{
    public static int find_it(int[] seq) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(var i in seq)
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
        return dict.First(x => x.Value % 2 != 0).Key;
    } 
}