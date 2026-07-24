public class Solution {
    private char[] sorted(string a){
        char[] char_a = a.ToCharArray();
        Array.Sort(char_a);
        return char_a;
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> baseStr = new Dictionary<string,List<string>>();
        for(int i=0; i < strs.Length;i++){
            string sorted_str = new string(sorted(strs[i]));
            if(!baseStr.ContainsKey(sorted_str)){
                baseStr.Add(sorted_str,new List<string> { strs[i] });
            }
            else{
                baseStr[sorted_str].Add(strs[i]);
                
            }
        }
        return baseStr.Values.ToList();
    }
}
