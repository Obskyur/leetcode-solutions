public class Solution {
    public string SimplifyPath(string path) {
        var tokens = parsePath(path);
        var stack = new Stack<string>();
        var result = new StringBuilder();

        foreach (var token in tokens) {
            if (token == ".")
                continue;
            if (token == "..") {
                if (stack.Count > 0)
                    stack.Pop();
                continue;
            }
            stack.Push(token);
        }
        
        while (stack.Count > 0) {
            result.Insert(0, "/" + stack.Pop());
        }

        return result.Length > 0 ? result.ToString() : "/";
    }

    private IEnumerable<string> parsePath(string path) => 
        path.Split("/").Where(s => !string.IsNullOrEmpty(s));
}