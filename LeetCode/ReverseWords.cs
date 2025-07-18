public class Solution
{
    public string ReverseWords(string s)
    {
        string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (i == 0)
                result = result + arr[i];
            else
                result = result + arr[i] + " ";
        }

        return result;
    }
}
