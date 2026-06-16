namespace _05_Two_Sum;

public class TwoSumTests
{
    [Fact]
    public void GivenTwoDifferentNumbers_ReturnsIndices()
    {
        var result = Solution.GetTwoSumIndices([2,7,11,15],9);
        Assert.Equal([0,1], result);
    }

    [Fact]
    public void GivenTwoSameNumbers_ReturnsIndices()
    {
        var result = Solution.GetTwoSumIndices([3,3],6);
        Assert.Equal([0,1], result);
    }
}
