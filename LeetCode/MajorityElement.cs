public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int freq = 0,
            ans = 0;

        foreach (int a in nums)
        {
            foreach (int b in nums)
            {
                if (a == b)
                    freq++;
            }

            if (freq > nums.Length / 2)
            {
                ans = a;
                break;
            }
            else
                freq = 0;
        }

        return ans;
    }
}
