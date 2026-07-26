namespace _15_Play_with_two_Strings;

public class WorkOnStringsTests
{
    [Fact]
    public void GivenPartialOverlap_ReturnsCorrectResult()
    {
        var result = Solution.WorkOnStrings("abc", "cde");
        Assert.Equal("abCCde", result);
    }

    [Fact]
    public void GivenOddAndEvenOccurrences_ReturnsCorrectResult()
    {
        var result = Solution.WorkOnStrings("ab", "aba");
        Assert.Equal("aBABA", result);
    }

    [Fact]
    public void GivenEvenOccurrences_ReturnsUnchangedCasing()
    {
        var result = Solution.WorkOnStrings("abab", "bababa");
        Assert.Equal("ABABbababa", result);
    }

    [Fact]
    public void GivenMixedCaseInput_ReturnsCorrectResult()
    {
        var result = Solution.WorkOnStrings("abcdeFg", "defgG");
        Assert.Equal("abcDEfgDEFGg", result); 
    }
}
