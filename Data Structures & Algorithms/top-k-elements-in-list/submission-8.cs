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

        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();

        foreach (KeyValuePair<int,int> key in freq){
            minHeap.Enqueue(key.Key,key.Value);
            if(minHeap.Count > k){
                minHeap.Dequeue();
            }
        }

        int[] ans = new int[k];
        for(int i = 0; i<k;i++){
            if(minHeap.Count != 0) ans[i] = minHeap.Dequeue();
        }
        return ans;
    }
}
