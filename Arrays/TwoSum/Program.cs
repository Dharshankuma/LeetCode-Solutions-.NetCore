//LeetCode - TwoSum - Solution 




public class Program
{
    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        TwoSumSolution solution = new TwoSumSolution();
        int[] result = solution.TwoSum(arr, target);
        Console.WriteLine($"Indices: [{result[0]},{result[1]}]");

        int[] result2 = solution.TwoSumHashMap(arr, target);
        Console.WriteLine($"Indices:[{result[0]},{result[1]}]");
    }
}

public class TwoSumSolution
{
    // Approach : Brute Force 
    // Time Complexity : O(n^2)
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

    //Approach : Optimized (HashMap)
    //Time Complexity : O(1)
    public int[] TwoSumHashMap(int[] nums , int target)
    {
        int n = nums.Length;
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < n; i++)
        {
            int diff = target - nums[i];
            if (map.ContainsKey(diff))
            {
                return new int[] { map[diff], i };
            }
            else
            {
                map[nums[i]] = i;
            }
        }

        return new int[] { };
    }
}

