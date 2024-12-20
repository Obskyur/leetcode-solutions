public class Solution {
    public bool IsPalindrome(string s) {
        string joinedStr = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
        return joinedStr.SequenceEqual(joinedStr.Reverse());
    }
}