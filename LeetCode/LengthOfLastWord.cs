public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] a = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int b = a[a.Length - 1].Length;

        return b;
    }
}
