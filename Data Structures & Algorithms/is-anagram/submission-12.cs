public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> count_s = new Dictionary<char,int>();

        foreach(char c in s){
            if(!count_s.ContainsKey(c)){
                count_s[c] = 0;
            }
            count_s[c] +=1;
        }

        foreach(char c in t){
            if(!count_s.ContainsKey(c)){
                return false;
            }
            count_s[c] -=1;
            if(count_s[c] < 0){
                return false;
            }
        }
        return true;
    }
}
