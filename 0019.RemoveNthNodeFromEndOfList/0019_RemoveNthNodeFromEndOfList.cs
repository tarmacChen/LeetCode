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
    public ListNode RemoveNthFromEnd(ListNodes head, int n) {   
        ListNode node = head;
        ListNode last;
        int s = 0;
        if(node != null){
            s = 1;
        }
        while(node.next != null){
            node = node.next;
            s++;
        }   
        n = s-n;
        if(n == 0){
            return head.next;
        }
        node = head;
        for(int i = 0; i < n-1; i++){
            node = node.next;
        }
        if(node.next != null){
            node.next = node.next.next;
        }
        return head;    
        
            
        
    }
}