public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var mappings = new Dictionary<char, char>();
        var mappedChars = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!mappings.ContainsKey(s[i]) && !mappedChars.Contains(t[i]))
            {
                mappings.Add(s[i], t[i]);
                mappedChars.Add(t[i]);
            }
            else if (!mappings.ContainsKey(s[i]) && mappedChars.Contains(t[i]))
            {
                return false;
            }
            else
            {
                if (mappings[s[i]] != t[i]) {
                    return false;
                }
            }
        }
        return true;
    }
}