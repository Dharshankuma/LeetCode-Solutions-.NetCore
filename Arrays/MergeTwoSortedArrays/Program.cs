//Merge Two Sorted Arrays
// Approach: Two pointers
// Time Complexity: O(n + m), where n and m are the lengths of the two arrays
// Space Complexity: O(1)

class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var solution = new Solution();

        // Example 1
        int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = new int[3] { 2, 5, 6 };
        int n = 3;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("Example 1 -> " + string.Join(", ", nums1));

        // Example 2 (edge case: nums1 has no initial elements)
        int[] a1 = new int[1] { 0 };
        int aM = 0;
        int[] a2 = new int[1] { 1 };
        int aN = 1;
        solution.Merge(a1, aM, a2, aN);
        Console.WriteLine("Example 2 -> " + string.Join(", ", a1));

        // Example 3 (both empty)
        int[] b1 = new int[0];
        int bM = 0;
        int[] b2 = new int[0];
        int bN = 0;
        // No merge needed but call to show behavior (no exception)
        solution.Merge(b1, bM, b2, bN);
        Console.WriteLine("Example 3 -> (length " + b1.Length + ")");
    }
}
