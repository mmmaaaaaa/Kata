public class Solution
{
    public static int CountDeadAnts(string ants)
    {
        var aant = 0;
        var nant = 0;
        var tant = 0;
        for(int i = 0; i < ants.Length; i++)
        {
            if(i + 2 < ants.Length && ants[i] == 'a' && ants[i+1] == 'n' && ants[i+2] == 't')
            {
                i += 3;
                continue;
            }
            if(ants[i] == 'a')
            {
                 aant ++;
            }
            if(ants[i] == 'n')
            {
                nant ++;
            }
            if(ants[i] == 't')
            {
                tant ++;
            }
        }
        return Math.Max(Math.Max(aant, nant), tant);
    }
}