namespace _25_Multiples_of_3_or_5;

public class SumOfMultiplesTests
{
    [Fact]
    public void GivenTen_ReturnsTwentyThree()
    {
        var result = Solution.SumOfMultiples(10);
        Assert.Equal(23, result);
    }
    
    [Fact]
    public void GivenTwoHundred_ReturnsNineThousandOneHundredSixtyEight()
    {
        var result = Solution.SumOfMultiples(200);
        Assert.Equal(9168, result);
    }

    [Fact]
    public void GivenZero_ReturnsZero()
    {
        var result = Solution.SumOfMultiples(0);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void GivenNegativeNumber_ReturnsZero()
    {
        var result = Solution.SumOfMultiples(-10);   
        Assert.Equal(0, result);
    }
}
