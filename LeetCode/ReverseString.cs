public class Solution
{
    public void ReverseString(char[] s)
    {
        List<char> a = new List<char>();

        for (int i = s.Length - 1; i >= 0; i--)
            a.Add(s[i]);

        for (int i = 0; i < s.Length; i++)
            s[i] = a[i];
    }
}
