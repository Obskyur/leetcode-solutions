public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var magLetters = new Dictionary<char, int>();

        foreach (char c in magazine) {
            if (magLetters.ContainsKey(c)) {
                magLetters[c]++;
            }
            else {
                magLetters.Add(c, 1);
            }
        };

        foreach (char c in ransomNote) {
            if (magLetters.Contains(c)) {
                if (--magLetters[c] == 0) {
                    magLetters.Remove(c);
                }
            }
            else {
                return false;
            }
        };

        return true;
    }
}