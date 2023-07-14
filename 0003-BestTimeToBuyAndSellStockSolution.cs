/// <description>
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
/// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
/// 
/// Example 1:
/// Input: prices = [7,1,5,3,6,4]
/// Output: 5
/// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
/// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
/// 
/// Example 2:
/// Input: prices = [7,6,4,3,1]
/// Output: 0
/// Explanation: In this case, no transactions are done and the max profit = 0.
/// 
/// Constraints:
/// 1 <= prices.length <= 10^5
/// 0 <= prices[i] <= 10^4
/// </description>
public class BestTimeToBuyAndSellStockSolution
{
    public int MaxProfit(int[] prices)
    {
        int buyingPrice = -1, sellingPrice;
        int maxProfit = 0;
        foreach (int price in prices)
        {
            if (buyingPrice == -1 || buyingPrice > price)
            {
                buyingPrice = price;
                sellingPrice = price;
            }
            else
            {
                sellingPrice = price;
            }

            maxProfit = Math.Max(maxProfit, sellingPrice - buyingPrice);
        }
        return maxProfit;
    }
}
/// <explanation>
/// If you are buying stock, that means you having it, thus your current profit will be 0. This you can achieve by, when you are assigning some value to buyingPrice, assign same value to sellingPrice, so profit will be 0 (buyingPrice - sellingPrice).
/// If you found stock price decreases set buyingPrice to the price at that day, when you set buyingPrice set the same sellingPrice
/// In other cases set the sellingPrice to the price.
/// Calculate maxProfit in each iteration.
/// </explanation>
