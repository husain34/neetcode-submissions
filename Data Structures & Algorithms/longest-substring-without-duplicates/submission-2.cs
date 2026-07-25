public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> log = new Dictionary<char,int>();
        int MaxChar = 0;
        int temp = 0;
        int i = 0;
        while(i < s.Length){
            if(log.ContainsKey(s[i])){
                i = log[s[i]] + 1;
                log.Clear();
            temp = 0;
            }
            else{
                log[s[i]] = i;
                temp++;
                if(temp > MaxChar) MaxChar = temp;
                i++;
            }
        }
        return MaxChar;
    }
}
