public class Solution {
    public bool IsSubsequence(string s, string t) {
        if ( string.IsNullOrEmpty(s) ) return true;
        for( int i = 0, j = 0; i < s.Length && j < t.Length; ) {
            if ( s[i] != t[j] ) {
                j++;
                continue;
            }
            else {
                i++;
                j++;
            }
            if ( i == s.Length )
                return true;
        };
        return false;
    }
}