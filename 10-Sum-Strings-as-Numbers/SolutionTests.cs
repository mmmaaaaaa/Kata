namespace _10_Sum_Strings_as_Numbers;

public class SumStringsTests
{
    [Fact]
    public void GivenWithoutCarry_ReturnsSum()
    {
        var result = Solution.SumStrings("123","456");
        Assert.Equal("579", result);
    }

    [Fact]
    public void GivenWithCarry_ReturnsSum()
    {
        var result = Solution.SumStrings("99","11");
        Assert.Equal("110", result); 
    }
}
