public class Solution {
    public bool IsValidSudoku(char[][] board) {
        List<HashSet<int>> rows = new List<HashSet<int>>();
        List<HashSet<int>> col = new List<HashSet<int>>();
        List<HashSet<int>> box = new List<HashSet<int>>();
        for(int i =0; i < 9; i++){
            rows.Add(new HashSet<int>());
            col.Add(new HashSet<int>());
            box.Add(new HashSet<int>());
        }
        for(int i =0; i < 9; i++){
            for(int j =0; j < 9; j++){
                if(board[i][j] == '.') continue;
                int val = board[i][j] - '0';
                if(rows[i].Contains(val)){
                    return false;
                }
                else{
                    rows[i].Add(val);
                }
                if(col[j].Contains(val)){
                    return false;
                }
                else{
                    col[j].Add(val);
                }
                int boxrow = i/3;
                int boxcol = j/3;
                int boxnum = boxrow *3 + boxcol;
                if(box[boxnum].Contains(val)){
                    return false;
                }
                else{
                    box[boxnum].Add(val);
                }
            }
        }
        return true;
    }
}
