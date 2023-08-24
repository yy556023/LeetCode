namespace _1._TwoSum;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        var result = Solution(nums, target);
        Console.WriteLine();
    }

    static int[] Solution(int[] nums, int target)
    {
        int i;
        int j = 0;

        for (i = 0; i < nums.Length; i++)
        {
            for (j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }

        return Array.Empty<int>();
    }
}
