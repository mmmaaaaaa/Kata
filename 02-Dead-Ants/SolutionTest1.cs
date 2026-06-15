namespace _02_Dead_Ants;

public class DeadAntsTest
{
    [Fact]
    public void GivenValidInput_ReturnDeadAntsCount()
    {
        var result = Solution.CountDeadAnts("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t");
        Assert.Equal(3, result);
    }

    [Fact]
    public void GivenEmptyString_ReturnZero()
    {
        var result = Solution.CountDeadAnts("");
        Assert.Equal(0, result);
    }

    [Fact]
    public void GivenOneAnt_ReturnZero()
    {
        var result = Solution.CountDeadAnts("ant");
        Assert.Equal(0, result);
    }

    [Fact]
    public void GivenWholeAnt_ReturnZero()
    {
        var result = Solution.CountDeadAnts("..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..");
        Assert.Equal(0, result);
    }

    [Fact]
    public void GivenALLDiedAnt_ReturnDeadAntsCount()
    {
        var result = Solution.CountDeadAnts("a..n.t..");
        Assert.Equal(1, result);
    }
}
