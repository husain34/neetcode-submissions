public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int size = nums.Length;
        int[] right = new int[size];
        int[] left = new int[size];
        int[] result = new int[size]; 
        int right_ele = 1;
        int left_ele = 1;
        for(int i=0; i < size ; i++){
            if(i == 0){
                right[i] = right_ele;
                left[size-1-i] = left_ele;
            
            }
            else{
                right_ele *= nums[i-1];
                right[i] = right_ele;
                left_ele *= nums[size-i];
                left[size-1-i] = left_ele;
            }

        }
        for(int i=0; i < nums.Length ; i++){
            result[i] = right[i]*left[i];
        }
        return result;
    }
}
