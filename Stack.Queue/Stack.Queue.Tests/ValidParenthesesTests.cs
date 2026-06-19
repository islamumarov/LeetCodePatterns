namespace Stack.Queue.Tests;

public class ValidParenthesesTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Test1(string s, bool expected)
    {
        var actual = ValidParentheses.IsValid(s);
        Assert.Equal(expected, actual);
        
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return ["()", true];
        yield return
        [
            "()[]{}",
            true
        ];
        yield return ["([)]", false];
    }
}