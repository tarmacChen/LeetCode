
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
    public ListNode MiddleNode(ListNode head) {
        if(head != null){
            int length = 0;
            ListNode temp = head;
            while(temp.next != null){
                length++;
                temp = temp.next;
            }
            temp = head;
            if(length % 2 == 0){
                length = length / 2;
            } else {
                length = length / 2 +1;
            }
            for(int i = 0; i < length; i++){
                temp = temp.next;
            }
            return temp;
        }
        return head;
    }
}
