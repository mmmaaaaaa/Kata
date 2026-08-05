namespace _34_Persistent_Bugger;

public class PersistenceTests
{
    [Fact]
    public void GivenSingleDigit_ReturnsZero()
    {
        var result = Solution.Persistence(4);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void GivenMultiDigitNumber_ReturnsPersistence()
    {
        var result = Solution.Persistence(999);
        Assert.Equal(4, result);
    }
}
