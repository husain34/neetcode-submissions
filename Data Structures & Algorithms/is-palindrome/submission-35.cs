public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 1 || s.Length == 0) return true;
        string lower_s = s.ToLower();
        int i = 0;
        int j = lower_s.Length-1;
        while(i < j){
            while(!char.IsLetter(lower_s[i]) && !char.IsNumber(lower_s[i])){
                i++;
                if(i > lower_s.Length-1) break;
            
            }
            while(!char.IsLetter(lower_s[j]) && !char.IsNumber(lower_s[j])){
                j--;
                if(j < 0) break;
            }
            if(i >= j || j <= i) {
                return true;
            }
            if(lower_s[i] != lower_s[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
