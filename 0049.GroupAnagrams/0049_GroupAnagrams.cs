public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++){
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string newStr = new string(chars);
            if(map.ContainsKey(newStr) == false){
                map.Add(newStr, new List<string>{strs[i]});
            }
            else {
                map[newStr].Add(strs[i]);
            }
        }
        IList<IList<string>> ret = new List<IList<string>>();
        foreach(string k in map.Keys){
            ret.Add(map[k]);
        }
        return ret;
    }
}