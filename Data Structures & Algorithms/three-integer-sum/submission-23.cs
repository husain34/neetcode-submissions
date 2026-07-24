public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> ans = new List<List<int>>();
        for(int k = 0 ; k < nums.Length - 1 ; k++){
            if (k > 0 && nums[k] == nums[k-1]) continue;
            int i = 0;
            int j = nums.Length -1;
            while(i <= j){
                if(nums[i] + nums[j] == -nums[k]){
                    if(i == k){
                        i++;
                    }
                    else if(j == k){
                        j--;
                    }
                    else if(i == j){
                        break;
                    }
                    else{
                        int[] arr = new int[] {nums[i],nums[j],nums[k]};
                        Array.Sort(arr);
                        List<int> result = arr.ToList();
                        bool isDup = false;
                        foreach(var l in ans){
                            if(l[0] == result[0] && l[1] == result[1] ){
                                i++;
                                isDup = true;
                                break;
                            }
                        }
                        if(isDup == false){
                            ans.Add(result);
                        }
                        
                    }
                    
                }
                else if(nums[i] + nums[j] > -nums[k]){
                    j--;
                }
                else if(nums[i] + nums[j] < -nums[k]){
                    i++;
                }
            }
        }
        return ans;
    }
}
