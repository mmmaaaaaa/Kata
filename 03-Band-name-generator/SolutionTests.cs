namespace _03_Band_name_generator;

public class BandNameTests
{
    [Fact]
    public void GivenWordWithDifferentFirstAndLastLetter_ReturnsTheWord()
    {
        var result = Solution.GetBandName("dolphin");
        Assert.Equal("The Dolphin", result);
    }

    [Fact]
    public void GivenWordWithSameFirstAndLastLetter_ReturnsRepeatWord()
    {
        var result = Solution.GetBandName("alaska");
        Assert.Equal("Alaskalaska", result);
    }
}
