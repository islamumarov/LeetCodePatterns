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

  [Fact]
  private void FindSubsetWithoutDubTest()
  {
    int[] nums = new int[] { 1, 3, 3 };
    IList<IList<int>> expected = new List<IList<int>>
    {
      new List<int>(),
      new List<int>() { 1 },
      new List<int>() { 3 },
      new List<int>() { 1, 3 },
      new List<int>() { 3, 3 },
      new List<int>() { 1, 3, 3 },

    };
    var actual = WithoutDuplicate.FindSubsetsWithoutDuplicates(nums);
    
    Assert.Equal(expected,actual);
    
  }

  [Fact]
  public void PermutationTest()
  {
    var nums = new int[] { 1, 3, 5 };
    var actual = Permutation.Permute(nums);
  }
}