namespace _13_ROT13;

public class ROT13Tests
{
    [Fact]
    public void GivenAlreadyROT13EncodedString_ReturnsCorrectResult()
    {
        var result = Solution.GetROT13EncodedString("EBG13 rknzcyr.");
        Assert.Equal("ROT13 example.", result);
    }

    [Fact]
    public void GivenNormalString_ReturnsROT13EncodedString()
    {
        var result = Solution.GetROT13EncodedString("This is my first ROT13 excercise!");
        Assert.Equal("Guvf vf zl svefg EBG13 rkprepvfr!", result);
    }
}
