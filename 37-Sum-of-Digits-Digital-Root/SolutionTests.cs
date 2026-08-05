namespace _37_Sum_of_Digits_Digital_Root;

public class DigitalRootTests
{
    [Fact]
    public void GivenMultiDigitNumber_ReturnsDigitalRoot()
    {
        var result = Solution.DigitalRoot(167346);
        Assert.Equal(9, result);
    }

    [Fact]
    public void GivenZero_ReturnsZero()
    {
        var result = Solution.DigitalRoot(0);
        Assert.Equal(0, result); 
    }
}
