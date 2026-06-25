public static class Solution
{
  public static string ReverseWords(string str)
  {
    var data = str.Split(' ');
    for (int i = 0; i < data.Length; i++)
    {
      data[i] = new string(data[i].Reverse().ToArray());
    }
    return string.Join(' ', data);
  }
}