// Remove Element from given value 
// Approach : Two Pointers
// Time Complexity : O(n)   
// Space Complexity : O(1)  

class RemoveElementArray
{
    public int RemoveElement(int[] nums, int val)
    {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            if (nums[left] == val)
            {
                nums[left] = nums[right];
                right--;
            }
            else
            {
                left++;
            }
        }

        return left;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        RemoveElementArray removeElementArray = new RemoveElementArray();
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;
        int newLength = removeElementArray.RemoveElement(nums, val);
        Console.WriteLine("New Length: " + newLength);
        Console.WriteLine("Modified Array: " + string.Join(", ", nums.Take(newLength)));
    }
}