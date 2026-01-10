class SingleNumberSolution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach(int number in nums)
        {
            result ^= number;
        }

        return result;
    }
}


class Program
{
    public static void Main()
    {
        SingleNumberSolution solution = new SingleNumberSolution();
        int[] nums = {4, 1, 2, 1, 2};
        int singleNumber = solution.SingleNumber(nums);
        System.Console.WriteLine($"The single number in the array is: {singleNumber}");
    }
}