public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Trim().Split(' ');
        var mappings = new Dictionary<char, string>();
        var mappedWords = new HashSet<string>();

        if (pattern.Length != words.Length) {
            return false;
        }

        foreach (var (ch, idx) in pattern.Select((ch, idx) => (ch, idx))) {
            if (!mappings.ContainsKey(ch) && !mappedWords.Contains(words[idx])) {
                mappings.Add(ch, words[idx]);
                mappedWords.Add(words[idx]);
            }
            else if (!mappings.ContainsKey(ch) && mappedWords.Contains(words[idx])) {
                return false;
            }
            else if (mappings.ContainsKey(ch)) {
                if (mappings[ch] != words[idx]) {
                    return false;
                }
            }
        }
        return true;
    }
}