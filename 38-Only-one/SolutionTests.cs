namespace _38_Only_one;

public class OnlyOneTests
{
    [Fact]
    public void GivenOnlyOneTrue_ReturnsTrue()
    {
        var result = Solution.OnlyOne(new bool[] { true, false, false });
        Assert.True(result);
    }
    
    [Fact]
    public void GivenMoreThanOneTrue_ReturnsFalse()
    {
        var result = Solution.OnlyOne(new bool[] { true, false, false, true });
        Assert.False(result);
    }
    
    [Fact]
    public void GivenNoFlags_ReturnsFalse()
    {
        var result = Solution.OnlyOne(new bool [] { });
        Assert.False(result);
    } 
}
