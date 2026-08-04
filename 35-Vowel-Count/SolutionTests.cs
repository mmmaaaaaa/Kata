namespace _35_Vowel_Count;

public class GetVowelCountTests
{
    [Fact]
    public void GivenStringWithVowels_ReturnsCount()
    {
        var result = Solution.GetVowelCount("abracadabra");
        Assert.Equal(5, result);
    }

    [Fact]
    public void GivenStringWithoutVowels_ReturnsZero()
    {
        var result = Solution.GetVowelCount("bbcc");
        Assert.Equal(0, result);
    }
}
