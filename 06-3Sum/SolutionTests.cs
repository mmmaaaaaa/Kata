namespace _06_3Sum;

public class ThreeSumTests
{
    [Fact]
    public void GivenNormalInput_ReturnsCorrectResult()
    {
        var result = Solution.GetThreeSumTriplets([-1,0,1,2,-1,-4]);
        Assert.Equal([[-1,-1,2],[-1,0,1]], result);
    }

    [Fact]
    public void GivenNoValidTriplets_ReturnsEmptyList()
    {
        var result = Solution.GetThreeSumTriplets([0,1,1]);
        Assert.Equal([], result);
    }

    [Fact]
    public void GivenAllZeroInput_ReturnsCorrectResult()
    {
        var result = Solution.GetThreeSumTriplets([0,0,0]);
        Assert.Equal([[0,0,0]], result);
    }
}
