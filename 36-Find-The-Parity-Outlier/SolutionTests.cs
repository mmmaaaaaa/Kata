namespace _36_Find_The_Parity_Outlier;

public class FindTests
{
    [Fact]
    public void GivenArrayWithOneOdd_ReturnsOddNumber()
    {
        var result = Solution.Find(new[] { 2,6,8,-10,3 });
        Assert.Equal(3, result);
    }

    [Fact]
    public void GivenArrayWithOneEven_ReturnsEvenNumber()
    {
        var result = Solution.Find(new[] { 206847684,1056521,7,17,1901,21104421,7,1,35521,1,7781 });
        Assert.Equal(206847684, result);
    }
}
