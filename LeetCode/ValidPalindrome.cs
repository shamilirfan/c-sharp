public class Solution
{
    public bool IsPalindrome(string s)
    {
        string a = "";
        int b = 0;
        s = s.ToLower();

        while (b < s.Length)
        {
            if (Char.IsLetterOrDigit(s[b]))
                a = a + s[b];
            b++;
        }

        return a.SequenceEqual(a.Reverse().ToArray());
    }
}
