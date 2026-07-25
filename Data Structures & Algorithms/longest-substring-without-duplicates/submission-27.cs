public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0 ) return 0;
        if(s.Length == 1 ) return 1;
        Dictionary<char,int> log = new Dictionary<char,int>();
        int MaxChar = 0;
        int temp = 0;
        int j = 0;
        for(int i = 0; i < s.Length; i++){
            if(log.ContainsKey(s[i])){
                if(j < log[s[i]] + 1) j = log[s[i]] + 1;
            }
            log[s[i]] = i;
            temp = i - j + 1;
            if(temp > MaxChar) MaxChar = temp;
        }
        return MaxChar;
    }
}
