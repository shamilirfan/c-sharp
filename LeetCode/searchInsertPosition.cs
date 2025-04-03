public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < target)
                result = result + 1;
        }

        return result;
    }
}