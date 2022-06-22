/*
 * @lc app=leetcode id=9 lang=csharp
 * Palindrome Number https://leetcode.com/problems/palindrome-number/description/
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        var str = x.ToString();
        var i = 0;
        var j = str.Length-1;
        while(i <= j)
        {
            if(str[i] == str[j])
            {
                i++;
                j--;
            }
            else return false;
        }
        return true;
    }
}
// @lc code=end

