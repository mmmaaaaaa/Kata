namespace _32_Exes_and_Ohs;

public class XOTests
{
    [Fact]
    public void GivenEqualXAndO_ReturnsTrue()
    {
        var result = Solution.XO("xxOo");
        Assert.True(result);
    }

    [Fact]
    public void GivenUnequalXAndO_ReturnsFalse()
    {   
        var result = Solution.XO("xxxm");
        Assert.False(result);
    }

    [Fact]
    public void GivenNoXOrO_ReturnsTrue()
    {
        var result = Solution.XO("zpzpzpp");
        Assert.True(result);
    }
}
