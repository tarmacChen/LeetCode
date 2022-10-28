public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 == 1){
            return false;
        }
        Dictionary<char, char> dict= new Dictionary<char, char>();
        dict.Add('}', '{');
        dict.Add(']', '[');
        dict.Add(')', '(');
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            if(dict.ContainsValue(c)){
                stack.Push(c);
            } else {
                if(stack.Count == 0){
                    return false;
                }
                if(stack.Peek() == dict[c]){
                    stack.Pop();
                } else {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}