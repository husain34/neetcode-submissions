public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq = new Dictionary<int,int>();

        foreach(int num in nums){
            if (!freq.ContainsKey(num))
            {
                freq[num] = 0;
            }
            freq[num] += 1;
        }

        int[] ans = new int[k];
        List<int> result = freq.Keys.OrderByDescending(key => freq[key]).Take(k).ToList();
        for(int i = 0; i<k;i++){
            ans[i] = result[i];
        }
        return ans;
    }
}
