class Moore_sVotingAlgorithm
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 1, 1, 1, 1, 2, 2 };
        int freq = 0, ans = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (freq == 0) ans = nums[i];
            if (ans == nums[i]) freq++;
            else freq--;
        }

        Console.WriteLine(ans);

    }
}