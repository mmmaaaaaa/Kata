namespace _07_Next_bigger_number_with_the_same_digits;

public class NextBiggerNumberTests
{
    [Fact]
    public void GivenNormalPermutation_ReturnCorrectResult()
    {
        var result = Solution.NextBiggerNumber(2017);
        Assert.Equal(2071, result);
    }

    [Fact]
    public void GivenNoPermutation_ReturnMinusOne()
    {
        var result = Solution.NextBiggerNumber(111);
        Assert.Equal(-1, result);
    }
}
