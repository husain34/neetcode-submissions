public class Solution {
    public int Trap(int[] height) {
        int rightPillar = 0;
        int leftPillar = 0;
        int size = height.Length - 1;
        int[] leftWaterPos = new int[size + 1];
        int[] rightWaterPos = new int[size + 1];
        int[] waterPos = new int[size + 1];
        for(int i = 0; i < size; i++){
            //leftpillar
            if(height[i] > leftPillar){
                leftPillar = height[i];
            }
            leftWaterPos[i] = leftPillar;
            
            //rightpillar
            if(height[size - i] > rightPillar){
                rightPillar = height[size - i];
            }
            rightWaterPos[size - i] = rightPillar;
        }

        for(int i = 0; i < size; i++){
            waterPos[i] = Math.Min(leftWaterPos[i],rightWaterPos[i]) - height[i];
        }
        int sum = 0;
        for(int i = 0; i <= size; i++){
        if(waterPos[i] > 0)
        sum += waterPos[i];
        }
        
        return sum;
    }
}
