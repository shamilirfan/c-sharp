public class Solution
{
    public bool IsPalindrome(int x)
    {
        string a = x.ToString();
        string b = "";
        bool c;

        for (int i = a.Length - 1; i >= 0; i--)
            b += a[i];

        if (a == b)
            c = true;
        else
            c = false;

        return c;
    }
}