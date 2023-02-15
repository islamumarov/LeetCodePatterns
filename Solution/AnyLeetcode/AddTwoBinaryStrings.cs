namespace AnyLeetcode;

public class AddTwoBinaryStrings
{
    // https://leetcode.com/problems/add-binary/
    public static string AddBinary(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        string res = "";
        int carry = 0;
        while (i >= 0 || j >= 0)
        {
            if (i >= 0)
            {
                carry += int.Parse(a[i].ToString());
                i--;
            }

            if (j >= 0)
            {
                carry += int.Parse(b[j].ToString());
                j--;
            }

            res = (carry % 2) + res;
            carry /= 2;
        }

        return carry > 0 ? carry + res : res;
    }
}