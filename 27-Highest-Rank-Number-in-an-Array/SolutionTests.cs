namespace _27_Highest_Rank_Number_in_an_Array;

public class HighestRankTests
{
    [Fact]
    public void GivenOneHighestRank_ReturnsHighestRankNumber()
    {
        var result = Solution.HighestRank(new[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 });
        Assert.Equal(3, result);
    }

    [Fact]
    public void GivenTwoHighestRank_ReturnsHighestRankNumber()
    {
        var result = Solution.HighestRank(new[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 });
        Assert.Equal(12, result); 
    }
}
