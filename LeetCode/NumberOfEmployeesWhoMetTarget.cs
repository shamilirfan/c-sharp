public class NumberOfEmployeesWhoMetTarget
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        int count = 0, i;

        for (i = 0; i < hours.Length; i++)
        {
            if (hours[i] >= target)
                count++;
        }
        return count;
    }
}