public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        bool result = true;

        if (nums.Length == nums.Distinct().ToArray().Length)
            result = false;

        return result;
    }
}
