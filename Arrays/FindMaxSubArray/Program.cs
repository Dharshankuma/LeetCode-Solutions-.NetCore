public class Solution
{
    public double FindMaxSubArray(int[] nums,int k)
    {
        int windowSum = 0;
        for(int i=0; i < k; i++)
        {
            windowSum += nums[i];
        }

        int maxSum = windowSum;
        for(int i = k; i < nums.Length; i++)
        {
            windowSum = windowSum - nums[i - k] + nums[i];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return (double)maxSum / k;
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = {1,12,-5,-6,50,3};
        int k = 4;
        double result = solution.FindMaxSubArray(nums, k);
        Console.WriteLine(result);
    }
}