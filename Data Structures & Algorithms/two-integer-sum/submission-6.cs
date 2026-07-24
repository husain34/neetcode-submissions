public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> log = new Dictionary<int,int>();
        for(int i=0; i<nums.Length ; i++)
        {
            if(log.TryGetValue(nums[i], out int num1)){
                int[] temp = {num1,i};
                return temp;
            }
            else{
                log.Add(target-nums[i],i);
            }
            
        }
        int[] temp2 = {-1,-1};
            return temp2;
    }
}
