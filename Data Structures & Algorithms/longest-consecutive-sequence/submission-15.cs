public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return 1;
        HashSet<int> seq = new HashSet<int>();
        HashSet<int> counted = new HashSet<int>();
        List<int> freq = new List<int>(); 
        for(int i = 0;i < nums.Length; i++){
            seq.Add(nums[i]);
        }
        for(int i = 0;i < nums.Length; i++){
            if(!counted.Contains(nums[i]) && !seq.Contains(nums[i]-1)){
                int j = 0;
                while(seq.Contains(nums[i]+j)){
                    counted.Add(nums[i]+j);
                    j++;
                }
                freq.Add(j);
            }
        }
        return freq.Max();
    }
}
