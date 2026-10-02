//75.Sort Colors

public class Solution
{
    public static void Main()
    {
        int[] nums = [2, 0, 2, 1, 1, 0];
        SortColors(nums);
        Console.WriteLine(string.Join(",", nums));
    }
    public static void SortColors(int[] nums)
    {
        int zeros = 0;
        int ones = 0;
        int twos = 0;

        foreach (int num in nums)
        {
            if (num == 0)
            {
                zeros++;
            }
            else if (num == 1)
            {
                ones++;
            }
            else
            {
                twos++;
            }
        }
        int index = 0;

        while (zeros > 0)
        {
            nums[index] = 0;
            index++;
            zeros--;
        }
        while (ones > 0)
        {
            nums[index] = 1;
            index++;
            ones--;

        }
        while (twos > 0)
        {
            nums[index] = 2;
            index++;
            twos--;
        }



    }
}
