public class Solution {
    public int MaxProfit(int[] prices) {
        int minValue = 9999999;
        int MaxProfit = 0;
        for(int i = 0; i < prices.Length;i++){
            if(prices[i] < minValue) minValue = prices[i];
            MaxProfit = Math.Max(prices[i] - minValue , MaxProfit);
        }
        return MaxProfit;
    }
}
