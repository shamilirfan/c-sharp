public class Solution
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        string[] s = sentence.Split().ToArray();
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].StartsWith(searchWord))
            {
                result = 1 + i;
                break;
            }
            else result = -1;
        }
        return result;
    }
}