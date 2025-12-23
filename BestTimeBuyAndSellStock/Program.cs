public class Stock
{
    public int MaxSolution(int[] prices)
    {
        int min, max = 0;
        min = int.MaxValue;
        max = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else
            {
                int profit = prices[i] - min;
                if(profit > max)
                {
                    max = profit;
                }
            }
        }

        return max;
    }
}


public class Program
{
    public static void Main()
    {
        int[] prices = { 7, 1,5,3,6,4 };
        Stock stock = new Stock()   ;
        int result = stock.MaxSolution(prices);
        Console.WriteLine(result);
        int[] prices2 = { 2, 4, 1 };
        int result2 = stock.MaxSolution(prices2);
        Console.WriteLine(result2);
    }
}