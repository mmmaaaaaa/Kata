namespace _18_Compute_the_Largest_Sum_of_all_Contiguous_Subsequences;

public class LargestSumTests
{
    [Fact]
    public void GivenEmptyArray_ReturnsZero()
    {
        var result = Solution.LargestSum(new int[]{});
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void GivenAllNegativeNumbers_ReturnsZero()
    {
        var result = Solution.LargestSum(new int[]{-1,-2,-3});
        Assert.Equal(0, result);
    }

    [Fact]
    public void GivenAllPositiveNumbers_ReturnsSum()
    {
        var result = Solution.LargestSum(new int[]{1,2,3,4});
        Assert.Equal(10, result); 
    }

    [Fact]
    public void GivenMixedNumbers_ReturnsLargestSum()
    {
        var result = Solution.LargestSum(new int[]{31,-41,59,26,-53,58,97,-93,-23,84});
        Assert.Equal(187, result);  
    }
}
