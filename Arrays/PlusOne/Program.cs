class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] newNumber = new int[n + 1];
        newNumber[0] = 1;
        return newNumber;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] digits = { 1, 2, 3 };
        int[] result = solution.PlusOne(digits);
        System.Console.WriteLine(string.Join(",", result));
    }
}