public class MinStack {
    private Stack<int> stack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();
    
    public MinStack() {
        
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0){
            minStack.Push(val);
        } else {
            minStack.Push(Math.Min(val, minStack.Peek()));
        }
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */