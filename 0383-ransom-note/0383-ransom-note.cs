public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var magLetters = new List<char>(magazine);

        foreach (char c in ransomNote) {
            if (magLetters.Contains(c)) {
                magLetters.Remove(c);
            }
            else {
                return false;
            }
        };

        return true;
    }
}