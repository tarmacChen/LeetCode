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
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null){
            return null;
        }
        ListNode tail = head;
        int count = 1;
        while(tail.next != null){
            count++;;
            tail = tail.next;
        }
        int t = count - k % count - 1;
        
        ListNode p = head;
        for(int i = 0; i < t; i++){
            p = p.next;
        }
        tail.next = head;
        ListNode result  = p.next;
        p.next = null;
        return result;
    }
}
