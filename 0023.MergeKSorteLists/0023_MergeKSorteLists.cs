/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0){
            return null;
        }
        ListNode ret = null;
        if(lists.Length >= 1){
            ret = lists[0];
        }
        for(int i = 1; i < lists.Length; i++){
            ret = MergeTwoList(ret, lists[i]);
        }
        return ret;
    }
    public ListNode MergeTwoList(ListNode list1, ListNode list2){
        if(list1 == null){
            return list2;
        }
        if(list2 == null){
            return list1;
        }
        if(list1.val < list2.val){
            list1.next = MergeTwoList(list1.next, list2);
            return list1;
        } else {
            list2.next = MergeTwoList(list1, list2.next);
            return list2;
        }
    }
}