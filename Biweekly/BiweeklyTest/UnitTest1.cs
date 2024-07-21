namespace BiweeklyTest;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 7, "Alice")]
    [InlineData(3, 12, "Alice")]
    [InlineData(4, 11, "Bob")]
    [InlineData(1, 1, "Bob")]
    public void AllShouldPass(int x, int y, string expected)
    {
        // Arrange
        var solver = new Biweekly.Biweekly();

        // Act
        var actual = solver.LosingPlayer(x, y);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("abaacbcbb", 5)]
    [InlineData("aa", 2)]
    public void MinimumLength_AllShouldPass(string s, int expected)
    {
        // Arrange
        var solver = new Biweekly.Biweekly();

        // Act
        var actual = 0; //0 solver.MinimumLength(s);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 0, 1, 2, 4, 3 }, 4, 2)]
    public void MinChanges_AllShouldPass(int[] nums, int k, int expected)
    {
        // Arrange
        var solver = new Biweekly.Biweekly();

        // Act
        var actual = solver.MinChanges(nums, k);

        //Assert
        Assert.Equal(expected, actual);
    }
}
