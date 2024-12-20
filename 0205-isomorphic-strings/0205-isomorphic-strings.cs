public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var mappings = new Dictionary<char, char>();
        string sCopy = string.Copy(s);

        if (s.Length != t.Length) {
            return false;
        }

        foreach (var (ch, idx) in s.Select((ch,idx) => (ch,idx))) {
            if (!mappings.ContainsKey(ch)) {
                if (mappings.ContainsValue(t[idx])) {
                    return false;
                }
                mappings[ch] = t[idx];
            }
            else {
                if (mappings[ch] != t[idx]){
                    return false;
                }
            }
        }
        return true;
    }
}