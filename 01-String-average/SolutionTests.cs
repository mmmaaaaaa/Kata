namespace _01_String_average;

public class StringAverageTests
{
    [Fact]
    public void GivenValidNumbers_ReturnsAverage()
    {
        var result = Solution.GetAverage("zero nine five two");
        Assert.Equal("four", result);
    }

    [Fact]
    public void GivenEmptyString_ReturnsNA()
    {
        var result = Solution.GetAverage("");
        Assert.Equal("n/a", result);
    }

    [Fact]
    public void GivenInvalidNumbers_ReturnsNA()
    {
        var result = Solution.GetAverage("ten");
        Assert.Equal("n/a", result);
    }

    [Fact]
    public void GivenValidNumbersWithRepeatedValues_ReturnsAverage()
    {
        var result = Solution.GetAverage("zero zero zero");
        Assert.Equal("zero", result);
    }
}
