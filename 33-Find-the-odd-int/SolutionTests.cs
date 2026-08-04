namespace _33_Find_the_odd_int;

public class find_it_Tests
{
    [Fact]
    public void GivenArrayWithOddOccurrence_ReturnsOddNumber()
    {
        var result = Solution.find_it(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 });
        Assert.Equal(5, result);
    }
}
