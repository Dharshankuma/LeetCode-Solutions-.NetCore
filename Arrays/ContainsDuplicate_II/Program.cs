class ContainseDuplicate
{
    public bool ContainsNearbyDuplicate(int[] nums,int k)
    {
        var numset = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (numset.Contains(nums[i]))
            {
                return true;
            }
            numset.Add(nums[i]);

            if(numset.Count > k)
            {
                numset.Remove(nums[i - k]);
            }

        }

        return false;
    }
}



public class Program
{
    public static void Main()
    {
        ContainseDuplicate duplicate = new ContainseDuplicate();
        int[] nums = { 1, 2, 3, 4, 1 };
        int k = 3;
        bool result = duplicate.ContainsNearbyDuplicate(nums, k);
        Console.WriteLine(result);
    }
}