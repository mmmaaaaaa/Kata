namespace _16_Simple_Fun__57_Runners_Meetings;

public class Solution
{
    public static int RunnersMeetings(int[]StartPosition, int[] speed)
    {
        var dict = new Dictionary<(int, int), HashSet<int>>();
        for (int i = 0; i < StartPosition.Length; i++)
        {
            for (int j = i + 1; j < speed.Length; j++)
            {
                if((StartPosition[i] - StartPosition[j]) * (speed[j] - speed[i]) > 0)
                {
                    
                    var numerator = StartPosition[i] - StartPosition[j];
                    var denominator = speed[j] - speed[i];
                    int gcd = Gcd(Math.Abs(numerator), Math.Abs(denominator));
                    var key = (numerator / gcd, denominator / gcd);
                    if (!dict.ContainsKey(key))
                    {
                        dict[key] = new HashSet<int>();
                    }
                    dict[key].Add(i);
                    dict[key].Add(j);
                }
            }
        }

        if (dict.Count == 0)
        {
            return -1;
        }
        else
        {
            return dict.Max(x => x.Value.Count);
        }
    }
    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}