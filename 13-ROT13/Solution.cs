public class Solution
{
    public static string GetROT13EncodedString(string input) {
        var result = "";
        foreach(var c in input)
        {
            if(char.IsLetter(c))
            {
                var baseChar = char.IsUpper(c) ? 'A' : 'a';
                result += (char)(baseChar + (c - baseChar + 13) % 26);
            }
            else
            {
                result += c;
            }
        }
    return result;
    }
}
