using System.Runtime.InteropServices.JavaScript;

namespace _10_Sum_Strings_as_Numbers;

public class Solution
{
    public static string SumStrings(string a, string b)
    {
        var result = string.Empty;
        int carry = 0;
        for (int i = a.Length -1, j = b.Length -1; i >= 0 || j >= 0; i--, j--)
        {
            int digitA = i >= 0 ? (a[i] - '0') : 0;
            int digitB = j >= 0 ? (b[j] - '0') : 0;
            result += (digitA + digitB + carry) % 10;
            carry = (digitA + digitB + carry) / 10;
        }

        if (carry > 0)
        {
            result += carry;   
        }
        return new string(result.Reverse().ToArray());
    }
}