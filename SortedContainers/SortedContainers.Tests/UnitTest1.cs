using SortedContainers;

namespace SortedContainers.Tests;

public static class TimeMapTestCases
{
    public static IEnumerable<object[]> AllImplementations() =>
    [
        [(Func<ITimeMap>)(() => new TimeMap())],
        [(Func<ITimeMap>)(() => new TimeMapV2())],
        [(Func<ITimeMap>)(() => new TimeMapV3())],
        [(Func<ITimeMap>)(() => new TimeMapV4())],
        [(Func<ITimeMap>)(() => new TimeMapV5())],
    ];
}

public class TimeBasedKeyValueStoreTests
{
    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void Get_ExactTimestamp_ReturnsValue(Func<ITimeMap> factory)
    {
        var map = factory();
        map.Set("foo", "bar", 1);

        Assert.Equal("bar", map.Get("foo", 1));
    }

    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void Get_TimestampBetweenTwoSets_ReturnsPreviousValue(Func<ITimeMap> factory)
    {
        var map = factory();
        map.Set("foo", "bar", 1);
        map.Set("foo", "baz", 3);

        Assert.Equal("bar", map.Get("foo", 2));
    }

    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void Get_TimestampBeforeAnySet_ReturnsEmpty(Func<ITimeMap> factory)
    {
        var map = factory();
        map.Set("foo", "bar", 5);

        Assert.Equal("", map.Get("foo", 3));
    }

    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void Get_NonExistentKey_ReturnsEmpty(Func<ITimeMap> factory)
    {
        var map = factory();

        Assert.Equal("", map.Get("missing", 1));
    }

    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void Get_TimestampAfterLastSet_ReturnsLastValue(Func<ITimeMap> factory)
    {
        var map = factory();
        map.Set("foo", "bar", 1);
        map.Set("foo", "baz", 3);

        Assert.Equal("baz", map.Get("foo", 10));
    }

    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void Get_MultipleKeys_ReturnCorrectValues(Func<ITimeMap> factory)
    {
        var map = factory();
        map.Set("foo", "bar", 1);
        map.Set("boo", "xyz", 2);

        Assert.Equal("bar", map.Get("foo", 1));
        Assert.Equal("xyz", map.Get("boo", 2));
        Assert.Equal("", map.Get("foo", 0));
    }

    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void Get_ExactMatchAmongMultipleTimestamps_ReturnsExact(Func<ITimeMap> factory)
    {
        var map = factory();
        map.Set("k", "a", 1);
        map.Set("k", "b", 2);
        map.Set("k", "c", 3);

        Assert.Equal("b", map.Get("k", 2));
    }

    [Theory]
    [MemberData(nameof(TimeMapTestCases.AllImplementations), MemberType = typeof(TimeMapTestCases))]
    public void LeetcodeExample1(Func<ITimeMap> factory)
    {
        var map = factory();
        map.Set("foo", "bar", 1);

        Assert.Equal("bar", map.Get("foo", 1));
        Assert.Equal("bar", map.Get("foo", 3));

        map.Set("foo", "bar2", 4);

        Assert.Equal("bar2", map.Get("foo", 4));
        Assert.Equal("bar2", map.Get("foo", 5));
    }
}
