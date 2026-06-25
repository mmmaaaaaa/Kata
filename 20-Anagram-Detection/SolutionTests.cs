namespace _20_Anagram_Detection;

public class AnagramDetectionTest
{
    [Fact]
    public void GivenTwoAnagrams_ReturnTrue()
    {
        var result = Solution.IsAnagram("Buckethead", "DeathCubeK");
        Assert.True(result);
    }

    [Fact]
    public void GivenTwoNonAnagrams_ReturnFalse()
    {
        var result = Solution.IsAnagram("abab", "cdcd");
        Assert.False(result);
    }

    [Fact]
    public void GivenSpaces_ReturnTrue()
    {
        var result = Solution.IsAnagram("", "");
        Assert.True(result);
    }
}
