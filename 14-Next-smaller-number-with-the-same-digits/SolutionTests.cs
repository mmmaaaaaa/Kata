namespace _14_Next_smaller_number_with_the_same_digits;

public class NextSmallerTests
{
    [Fact]
    public void GivenNormalPermutation_ReturnCorrectResult()
    {
        var result = Solution.NextSmallerNumber(2071);
        Assert.Equal(2017, result);
    }
    [Fact]
    public void GivenNoPermutation_ReturnMinusOne()
    {
        var result = Solution.NextSmallerNumber(1027);
        Assert.Equal(-1, result);
    }
}
