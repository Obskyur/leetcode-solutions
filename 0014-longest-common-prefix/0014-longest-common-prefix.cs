public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new();
        string shortest = strs.OrderBy( s => s.Length ).First();
        foreach ( var (c, i) in shortest.Select((c,i) => (c, i)) ) {
            if ( strs.Any( s => s[i] != c )) break;
            sb.Append(c);
        }
        return sb.ToString();
    }
}