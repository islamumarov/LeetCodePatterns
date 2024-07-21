namespace Biweekly;

public class Biweekly
{
    /// <summary>
    ///You are given two positive integers x and y, denoting the number of coins with values 75 and 10 respectively.
    /// Alice and Bob are playing a game. Each turn, starting with Alice, the player must pick up coins with a total value 115. If the player is unable to do so, they lose the game.
    /// Return the name of the player who wins the game if both players play optimally.
    /// </summary>


    public string LosingPlayer(int x, int y)
    {
        int Alice = 0;
        int Bob = 0;

        string winner = "";

        int total = 115;
        int i = 1;

        if (x == 0)
            return winner;
        while (x > 0 && y > 0)
        {
            winner = x - 1 >= 0 && y - 4 >= 0 ? "Alice" : "Bob";
            x -= 1;
            y -= 4;

            winner = x - 1 >= 0 && y - 4 >= 0 ? "Bob" : winner;
            x -= 1;
            y -= 4;
        }

        return winner;
    }

    /// <summary>
    /// You are given a string s.
    // You can perform the following process on s any number of times:
    //
    // Choose an index i in the string such that there is at least one character to the left of index i that is equal to s[i], and at least one character to the right that is also equal to s[i].
    // Delete the closest character to the left of index i that is equal to s[i].
    // Delete the closest character to the right of index i that is equal to s[i].
    // Return the minimum length of the final string s that you can achieve.

    //Example 1:
    //
    //Input: s = "abaacbcbb"
    //
    //Output: 5
    //
    //Explanation:
    //We do the following operations:
    //
    //Choose index 2, then remove the characters at indices 0 and 3. The resulting string is s = "bacbcbb".
    //Choose index 3, then remove the characters at indices 0 and 5. The resulting string is s = "acbcb".
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    /*
    public int MinimumLength(string s)
    {

    };
    */

    /// <summary>
    /// You are given an integer array nums of size n where n is even, and an integer k.

    //You can perform some changes on the array, where in one change you can replace any element in the array with any integer in the range from 0 to k.
    //
    //    You need to perform some changes (possibly none) such that the final array satisfies the following condition:
    //
    //There exists an integer X such that abs(a[i] - a[n - i - 1]) = X for all (0 <= i < n).
    //Return the minimum number of changes required to satisfy the above condition.


    public int MinChanges(int[] nums, int k)
    {
        int x;
        int n = nums.Length;
        int[] arr = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            arr[i] = Math.Abs(nums[i] - nums[n - i - 1]);
        }

        return 0;
    }
}
