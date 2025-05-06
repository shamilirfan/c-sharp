public class Solution
{
    public string ReverseVowels(string s)
    {
        string[] a = new string[s.Length];
        List<string> b = new List<string>();
        int x = 0;

        for (int i = 0; i < s.Length; i++)
            a[i] = s[i].ToString();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i].ToString() == "a" || s[i].ToString() == "e" || s[i].ToString() == "i" || s[i].ToString() == "o" || s[i].ToString() == "u" ||
             s[i].ToString() == "A" || s[i].ToString() == "E" || s[i].ToString() == "I" || s[i].ToString() == "O" || s[i].ToString() == "U") b.Add(s[i].ToString());
        }

        //
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == "a" || a[i] == "e" || a[i] == "i" || a[i] == "o" || a[i] == "u" ||
            a[i] == "A" || a[i] == "E" || a[i] == "I" || a[i] == "O" || a[i] == "U")
            {
                a[i] = b[x];
                x++;
            }
        }

        string result = string.Join("", a);
        return result;
    }
}