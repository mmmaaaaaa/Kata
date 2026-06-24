namespace _04_Count_the_number_of_Duplicates;

public class CountDuplicatesTests
{
    [Fact]
    public void GivenNoRepeatsString_ReturnZero()
    {
        var result = Solution.GetDuplicatesNumber("abcde");
        Assert.Equal(0, result);
    }

    [Fact]
    public void GivenOnlyOneRepeatsString_ReturnOne()
    {
        var result = Solution.GetDuplicatesNumber("indivisibility");
        Assert.Equal(1, result);
    }

    [Fact]
    public void GivenMixedCaseString_ReturnTwo()
    {
        var result = Solution.GetDuplicatesNumber("aA11");
        Assert.Equal(2, result);
    }

    [Fact]
    public void GivenSpaceString_ReturnTwo()
    {
        var result = Solution.GetDuplicatesNumber(" ");
        Assert.Equal(0, result);
    }
}
