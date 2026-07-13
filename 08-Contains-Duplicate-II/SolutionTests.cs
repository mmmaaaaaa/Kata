namespace _08_Contains_Duplicate_II;

public class ContainsNearbyDuplicateTests
{
    [Fact]
    public void GivenDistanceWithinK_ReturnTrue()
    {
        var result = Solution.ContainsNearbyDuplicate([1,0,1,1], 3);
        Assert.True(result);
    }

    [Fact]
    public void GivenDistanceExceedsK_ReturnFalse()
    {
        var result = Solution.ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 2);
        Assert.False(result);
    }
    
    [Fact]
    public void GivenSameNumberAppearsMultipleTimes_ReturnFalse()
    {
        var result = Solution.ContainsNearbyDuplicate([1, 1, 1], 0);
        Assert.False(result);
    }
}
