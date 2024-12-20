public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var mappings = new Dictionary<char, char>();
        var mappedChars = new HashSet<char>();

        if (s.Length != t.Length) {
            return false;
        }

        foreach (var (ch, idx) in s.Select((ch,idx) => (ch,idx))) {
            if (!mappings.ContainsKey(ch)) {
                if (mappedChars.Contains(t[idx])) {
                    return false;
                }
                mappings.Add(ch, t[idx]);
                mappedChars.Add(t[idx]);
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