

using Hash_sets_and_loops;

class Program()
{
    static int Main()
    {
        int[] nums = { 3, 5, 1, 4, 5, 2, 6 };
        Console.WriteLine(HashsetCalculation.Calculate(nums));


        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    Console.WriteLine(nums[i]);
                    return nums[i];

                }
            }
        }
        Console.WriteLine("-1");
        return -1;
    }
}

