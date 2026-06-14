public class Solution
{
    public static string GetAverage(string numbers)
    {
        var dict = new Dictionary<string, int>
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
        };
        if(string.IsNullOrEmpty(numbers))
        {
            return "n/a";
        }
        var data = numbers.Split(' ');
        var sum = 0;
        foreach(var i in data)
        {
            if(dict.ContainsKey(i))
            {
                int value = dict[i];
                sum += value;
            }
            else
            {
                return "n/a";
            }
        }
        var average = sum/data.Length;
        return dict.FirstOrDefault(x => x.Value == average).Key;
    }
}