class Sqrtx
{
    public int Solution(int x)
    {
        int left = 1;
        int right = x;
        int result = 1;

        if(x < 2)
        {
            return x;
        }

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (mid  == x / mid)
            {
                return mid;
            }
            else if(mid < x / mid)
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Sqrtx sqrtx = new Sqrtx();
        int x = 8;
        int result = sqrtx.Solution(x);
        Console.WriteLine($"The integer square root of {x} is: {result}");
    }
}