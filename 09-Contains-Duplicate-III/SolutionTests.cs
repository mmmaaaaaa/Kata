namespace _09_Contains_Duplicate_III;

public class ContainsNearbyAlmostDuplicateTests
{
    [Fact]
    public void GivenValidIndexAndValueDiff_ReturnTrue()
    {
        var result = Solution.ContainsNearbyAlmostDuplicate([1,2,3,1], 3, 0);
        Assert.True(result);
    }

    [Fact]
    public void GivenExceedingIndexOrValueDiff_ReturnFalse()
    {
        var result = Solution.ContainsNearbyAlmostDuplicate([1,5,9,1,5,9], 2, 3);
        Assert.False(result);
    }

    [Fact]
    public void GivenExceedingIndexAndValueDiff_ReturnTrue()
    {
        var result = Solution.ContainsNearbyAlmostDuplicate([8,7,15,1,6,1,9,15], 1, 3);
        Assert.True(result); 
    }
    
    [Fact]
    public void GivenNegativeNumbers_ReturnFalse()
    {
        var result = Solution.ContainsNearbyAlmostDuplicate([-3, 3], 2, 4);
        Assert.False(result);
    }
}
