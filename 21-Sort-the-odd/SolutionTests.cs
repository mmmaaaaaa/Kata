namespace _21_Sort_the_odd;

public class SortTheOddTest
{
    [Fact]
    public void GivenAllOddNumbers_ReturnSortedArray()
    {
        var result = Solution.SortArray([5, 3, 1, 7, 9]);
        Assert.Equal([1, 3, 5, 7, 9], result);
    }

    [Fact]
    public void GivenAllEvenNumbers_ReturnSameArray()
    {
        var result = Solution.SortArray([2, 4, 6, 8]);
        Assert.Equal([2, 4, 6, 8], result);
    }

    [Fact]
    public void GivenMixedNumbers_ReturnSortedOddNumbers()
    {
        var result = Solution.SortArray([5, 3, 2, 8, 1, 4]);
        Assert.Equal([1, 3, 2, 8, 5, 4], result);
    }
}
