namespace _25_Multiples_of_3_or_5;

public class Solution
{
    public static int SumOfMultiples(int value)
    {
        var sum = 0;
        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}