using src;

namespace SubsetsTest;

public class UnitTest1
{
  [Fact]
  private void findSubsetsTest()
  {
    List<int> list = new List<int>() { 1, 3, 5 };
    var actual = PermutSubsets.FindSubsets(list);
    
    Assert.Equal((int)Math.Pow(2,list.Count),actual.Count);

  }
}