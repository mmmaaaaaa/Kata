namespace _16_Simple_Fun__57_Runners_Meetings;

public class RunnersMeetingsTests
{
    [Fact]
    public void GivenAllRunnersMeet_ReturnsThree()
    {
        var result = Solution.RunnersMeetings(new int[]{1, 4, 2}, new int[]{27, 18, 24});
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void GivenTwoRunnersMeet_ReturnsTwo()
    {
        var result = Solution.RunnersMeetings(new int[]{1, 4, 2}, new int[]{5, 6, 2});
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void GivenSameSpeed_ReturnsMinusOne()
    {
        var result = Solution.RunnersMeetings(new int[]{1, 2, 3}, new int[]{1, 1, 1});
        Assert.Equal(-1, result);
    }
    
    [Fact]
    public void GivenTwoRunnersWithDifferentSpeed_ReturnsTwo()
    {
        var result = Solution.RunnersMeetings(new int[]{1, 1000}, new int[]{23, 22});
        Assert.Equal(2, result);
    } 
}
