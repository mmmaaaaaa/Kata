namespace _22_Counting_Change_Combinations;

public class CountCombinationsTests
{
    [Fact]
    public void GivenValidCombinations_ReturnsCount()
    {
        var result = Solution.CountCombinations(10, new[] { 5, 2, 3 });
        Assert.Equal(4, result);
    }

    [Fact]
    public void GivenNoCombinations_ReturnsZero()
    {
        var result = Solution.CountCombinations(11, new[] { 5, 7 });
        Assert.Equal(0, result); 
    }
}
