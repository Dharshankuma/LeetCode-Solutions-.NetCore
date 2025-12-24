// LeetCode: Move Zeroes
// Approach: Two Pointers (In-place)
// Time Complexity: O(n)
// Space Complexity: O(1)

class MoveZerosSolution
{
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] != 0)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
            }
        }
    }
}


class Program
{
    public static void Main()
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        MoveZerosSolution solution = new MoveZerosSolution();
        solution.MoveZeroes(nums);
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
}