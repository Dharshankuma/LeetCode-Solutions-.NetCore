class Solution
{

    //time complexity will be O(n log n) and space complexity will be O(n)
    public int MajorityElementHashTable(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();  
        foreach(int num in nums)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map[num] = 1;
            }
        }

        var maxCount = map.OrderByDescending(x => x.Value).First();
        return maxCount.Key;
    }

    // implementation of Moore's Voting Algorithm O(1) space and O(n) time
    public int MajorityElementMooreVote(int[] nums)
    {
        int n = nums.Length;
        int element = 0;
        int count = 0;
        foreach (int num in nums)
        {
            if (count == 0)
            {
                count++;
                element = num;
            }
            else if (num == element)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        int count2 = 0;
        foreach (int num in nums)
        {
            if (num == element)
            {
                count2++; // for verifying if the element is really a major
            }
        }

        if (count2 > (n / 2))
        {
            return element;
        }

        return -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 3, 2, 3 };
        int majorityElementHashTable = solution.MajorityElementHashTable(nums);
        int majorityElementMooreVote = solution.MajorityElementMooreVote(nums);
        Console.WriteLine($"Majority Element (Hash Table): {majorityElementHashTable}");
        Console.WriteLine($"Majority Element (Moore's Voting): {majorityElementMooreVote}");
    }
}