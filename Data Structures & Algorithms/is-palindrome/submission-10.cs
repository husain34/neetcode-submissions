public class Solution {
    public bool IsPalindrome(string s) {
        string lower_s = s.ToLower();
        string filtered_s = "";
        for(int i = 0 ; i < lower_s.Length ; i++){
            if(lower_s[i] != ' ' && char.IsLetter(lower_s[i]) || char.IsNumber(lower_s[i])){
                filtered_s += lower_s[i];
            }
        }
        for(int i = 0 ; i < filtered_s.Length/2 ; i++){
            if(filtered_s[i] != filtered_s[filtered_s.Length - 1 - i]){
                return false;
            }
        }
        return true;
    }
}
