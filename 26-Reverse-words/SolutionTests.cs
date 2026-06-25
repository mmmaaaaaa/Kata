namespace _26_Reverse_words;

public class ReverseWordsTest1
{
    [Fact]
    public void GivenOneWord_ReturnReversedWord()
    {
        var result = Solution.ReverseWords("apple");
        Assert.Equal("elppa", result);
    }

    [Fact]
    public void GivenMultipleWords_ReturnReversedWords()
    {
        var result = Solution.ReverseWords("double  spaces!");
        Assert.Equal("elbuod  !secaps", result);
    }
}
