namespace _37_Sum_of_Digits_Digital_Root;

public class Solution
{
    public static int DigitalRoot(long n)
    {
        while (n >= 10)
        {
            n = n.ToString().Sum(c => c - '0');
        } 
        return (int)n;
    }
}