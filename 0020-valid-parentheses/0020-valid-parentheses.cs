public class Solution {
    public bool IsValid(string s) {
        var pStack = new Stack<char>();
        foreach (var c in s) {
            switch (c) {
                case '(': 
                    pStack.Push(')');
                    break;
                case '{':
                    pStack.Push('}');
                    break;
                case '[':
                    pStack.Push(']');
                    break;
                default:
                    if (pStack.Count == 0 || pStack.Pop() != c)
                        return false;
                    break;
            }
        }
        return pStack.Count == 0;
    }
}