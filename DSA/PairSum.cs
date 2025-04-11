class PairSum
{
    public static void Main(string[] args)
    {
        // Pair Sum - Return pair in sorted array with target sum
        int[] nums = [2, 7, 11, 15];
        int target = 26, ans = 0, indexOFi = 0, indexOFj = 0;

        //// 1
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = nums.Length - 1; j > 0;)
            {
                if (nums[i] + nums[j] < target) i++;
                else if (nums[i] + nums[j] > target) j--;
                else if (nums[i] + nums[j] == target)
                {
                    ans = nums[i] + nums[j];
                    indexOFi = i; indexOFj = j; i = nums.Length;
                    break;
                }
            }
        }

        Console.WriteLine($"index of i = {indexOFi}, index of j = {indexOFj}, ans = {ans}");





        //// 2
        // int target = 26, ans = 0, i = 0, j = nums.Length - 1, indexOFi = 0, indexOFj = 0;

        // while (true)
        // {
        //     if (nums[i] + nums[j] < target) i++;
        //     else if (nums[i] + nums[j] > target) j--;
        //     else if (nums[i] + nums[j] == target)
        //     {
        //         ans = nums[i] + nums[j];
        //         indexOFi = i; indexOFj = j;
        //         break;
        //     }
        // }

        // Console.WriteLine($"indexOFi = {indexOFi}, indexOFj = {indexOFj}, ans = {ans}");

    }
}