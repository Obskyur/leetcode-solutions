public class Solution {
    public bool IsValid(string s) {
        var pStack = new Stack<char>();
        foreach (var c in s) {
            if (c == '(') {
                pStack.Push(')');
                continue;
            }
            if (c == '{') {
                pStack.Push('}');
                continue;
            }
            if (c == '[') {
                pStack.Push(']');
                continue;
            }
            if (pStack.Count == 0 || pStack.Pop() != c)
                return false;
        };
        return pStack.Count == 0;
    }
}