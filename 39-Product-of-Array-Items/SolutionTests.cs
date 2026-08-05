namespace _39_Product_of_Array_Items;

public class ProductTests
{
    [Fact]
    public void GivenNullArray_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Solution.Product(null));
    }
    
    [Fact]
    public void GivenEmptyArray_ThrowsInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => Solution.Product(new int[]{ }));
    }
    
    [Fact]
    public void GivenValidArray_ReturnsProduct()
    {
        var result = Solution.Product(new int[]{ -2, 6, 7, 8 });
        Assert.Equal(-672, result);
    }
}
