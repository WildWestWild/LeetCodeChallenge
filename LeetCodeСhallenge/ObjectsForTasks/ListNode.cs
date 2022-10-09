namespace LeetCodeСhallenge.ObjectsForTasks;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static List<int> HeadListNodeInArray(ListNode head)
    {
        List<int> listInts = new List<int>();
        while (head is not null)
        {
            listInts.Add(head.val);
            head = head.next;
        }
        
        Console.WriteLine($"[{string.Join(", ", listInts)}]");

        return listInts;
    }
}