//LeetCode - TwoSum - Solution 
// Approach : Brute Force 
// Time Complexity : O(n^2)
// Space Compmlexity : 0(1)

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums,int target)
    {
        int[] index = new int[2];
        
        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    index[0] = i;
                    index[1] = j;
                }
            }
        }

        return index;
    }
}

public class Program
{
    static void main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        TwoSumSolution solution = new TwoSumSolution();
        int[] result = solution.TwoSum(arr, target);
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}