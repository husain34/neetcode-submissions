public class Solution {

    public string Encode(IList<string> strs) {
        string encrypted = "";

        foreach(string str in strs){
            string length = str.Length.ToString();
            encrypted += length.ToString() + "#"+ str;
        }
        return encrypted;
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        int pointer = 0;
        while(pointer < s.Length)
        {
            string num = "";
            while(s[pointer] != '#'){
                num += s[pointer];
                pointer++;
            }
            int length;
            int.TryParse(num, out length);
            string substring = s.Substring(pointer+1,length);
            strs.Add(substring);
            pointer += length + 1;
        }
        return strs;
   }
}
