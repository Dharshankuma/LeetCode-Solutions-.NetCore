class SearchInsertPosition
{
    public int SearchInsert(int[] nums,int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return low;
    }
}



class Program
{
    public static void Main()
    {
        SearchInsertPosition sip = new SearchInsertPosition();
        int[] nums = { 1, 3, 5, 6 };
        int target = 5;
        int result = sip.SearchInsert(nums, target);
        System.Console.WriteLine($"The target {target} is at index: {result}");
    }
}