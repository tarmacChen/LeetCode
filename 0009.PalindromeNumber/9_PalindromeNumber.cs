public class Solution {
    public bool IsPalindrome(int x) {
        string reversedStr = "";
        string str = x.ToString();
        for(int i = str.Length - 1; i >= 0; i--){
            reversedStr += str[i];
        }
        return (reversedStr == str);
    }
}
