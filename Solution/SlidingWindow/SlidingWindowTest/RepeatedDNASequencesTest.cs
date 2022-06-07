using System.Collections.Generic;
using System.Linq;
using SlidingWindow;
using Xunit;

namespace SlidingWindowTest;

public class RepeatedDNASequencesTest
{
    [Fact]
    public static void FindRepeatedDnaSequences()
    {
        var str = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
        var expected = new List<string>();
        expected.Add("AAAAACCCCC");
        expected.Add("CCCCCAAAAA");
        var actual = RepeatedDNASequences.FindRepeatedDnaSequences(str);
        Assert.Equal(expected,actual);
    }
}