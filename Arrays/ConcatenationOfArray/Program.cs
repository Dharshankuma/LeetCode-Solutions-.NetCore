
public class ConcatenationofArray
{
    public int[] GetConcatenation(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[2 * n];
        for (int i = 0; i < n; i++)
        {
            result[i] = nums[i];
            result[i + n] = nums[i];
        }
        return result;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        ConcatenationofArray solution = new ConcatenationofArray();
        int[] nums = { 1, 2, 3 };
        int[] concatenatedArray = solution.GetConcatenation(nums);
        
        // Print the result
        Console.WriteLine(string.Join(", ", concatenatedArray));
    }
}