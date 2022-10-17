using LeetCodeСhallenge.ObjectsForTasks;

namespace LeetCodeСhallenge.LeetCode;

public static class SwapNodesInPairsTask
{
    private static ListNode? _headSaved;
    private static ListNode? _prevNext;

    public static ListNode? SwapPairs(ListNode? head)
    {
        _headSaved ??= head;
        if (head is null || head.next is null)
        {
            return _headSaved;
        }
        
        _prevNext = Swap(head, head.next);
        return SwapPairs(_prevNext.next);
    }

    private static ListNode Swap(ListNode first, ListNode second)
    {
        if (_prevNext is null)
            _headSaved = second;
        else
            _prevNext.next = second;

        first.next = second.next;
        second.next = first;
        return first;
    }
}