public class Solution
{
    public int Reverse(int x)
    {
        char[] y = Convert.ToString(x).ToCharArray();
        string z = "";

        if (y[0] == '-')
        {
            z = z + '-';
            for (int i = y.Length - 1; i > 0; i--)
                z = z + y[i];
        }
        else if (y[y.Length - 1] == '0')
        {
            for (int i = y.Length - 2; i >= 0; i--)
                z = z + y[i];
        }
        else
        {
            for (int i = y.Length - 1; i >= 0; i--)
                z = z + y[i];
        }

        bool a = int.TryParse(z, out int reverse);

        return reverse;
    }
}