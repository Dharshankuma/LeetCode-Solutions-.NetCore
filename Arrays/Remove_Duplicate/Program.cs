// Remove Duplicate Elements from Sorted Array 
// Approach : Two Pointers Technique
// Time Complexity : O(n)
// Space Complexity : O(1)
class RemoveDuplicateElement
{
    public int RemoveDuplicates(int[] nums)
    {
        int left = 0;
        for (int right = 1; right < nums.Length; right++)
        {
            if (nums[left] != nums[right])
            {
                left++;
                nums[left] = nums[right];
            }
        }
        return left + 1;
    }
}


class Program
{
    public static void Main(string[] args)
    {
        RemoveDuplicateElement remover = new RemoveDuplicateElement();
        int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
        int newLength = remover.RemoveDuplicates(nums);
        Console.WriteLine("New length: " + newLength);
        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < newLength; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}