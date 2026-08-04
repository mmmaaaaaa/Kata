namespace _28_Get_the_Middle_Character;

public class GetMiddleTests
{
    [Fact]
    public void GivenOddLengthString_ReturnsMiddleChar()
    {
        var result = Solution.GetMiddle("testing");
        Assert.Equal("t", result);
    }

    [Fact]
    public void GivenEvenLengthString_ReturnsMiddleChar()
    {
        var result = Solution.GetMiddle("test");
        Assert.Equal("es", result);
    }
    
    [Fact]
    public void GivenSingleChar_ReturnsSameChar()
    {
        var result = Solution.GetMiddle("A");
        Assert.Equal("A", result);
    }
}
