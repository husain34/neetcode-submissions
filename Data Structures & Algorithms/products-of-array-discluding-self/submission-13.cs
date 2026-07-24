public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int size = nums.Length;
        int[] result = new int[size]; 
        Array.Fill(result, 1);
        int right_ele = 1;
        int left_ele = 1;
        for(int i=0; i < size ; i++){
            if(i == 0){
                continue;
            }
            else{
                right_ele *= nums[i-1];
                result[i] *= right_ele;
                left_ele *= nums[size-i];
                result[size-1-i] *= left_ele;
            }

        }
        return result;
    }
}
