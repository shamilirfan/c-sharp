public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] margedArray = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        double dbl = 0;

        if (margedArray.Length % 2 != 0)
            dbl = margedArray[margedArray.Length / 2];
        else
        {
            double a = margedArray[(margedArray.Length / 2) - 1] + margedArray[margedArray.Length / 2];
            dbl = a / 2;
        }

        return dbl;
    }
}