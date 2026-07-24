public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        char[] chars_s = s.ToCharArray();
        Array.Sort(chars_s);
        char[] chars_t = t.ToCharArray();
        Array.Sort(chars_t);

        for(int i = 0; i < chars_s.Length; i++){
            if(chars_s[i] != chars_t[i]){
                return false;
            }
        }
        return true;
    }
}
