public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length -1;
        while(i <= j){
            if(numbers[i] + numbers[j] == target){
                int[] ans1 = new int[] {i+1 , j+1};
                return ans1;
            }
            else if(numbers[i] + numbers[j] > target && numbers[j] >= target){
                j--;
            }
            else if(numbers[i] + numbers[j] > target && numbers[j] <= target){
                j--;
            }
            else if(numbers[i] + numbers[j] < target ){
                i++;
            }
        }
        int[] ans = new int[] {i+1 , j+1};
        return ans;
    }
}
