using LeetCodeСhallenge.ObjectsForTasks;

namespace LeetCodeСhallenge.LeetCode;

public static class MergeTwoSortedListsTask
{
    private static ListNode _headList1;
    private static ListNode _headList2;
    private static ListNode _prevMatcher;
    private static ListNode _matcher;

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        _headList1 = list1;
        _headList2 = list2;
        _matcher = list1;
        _prevMatcher = new ListNode(-51, _matcher);
        
        while (_headList2 is not null)
        {
            if (_matcher is null || _headList2.val <= _matcher.val)
            {
                // Сохраняем ссылку для вставки
                var nodeInsert = _headList2;
                // Сохраняем голову второго списка
                _headList2 = nodeInsert.next;
                if (_prevMatcher is null || _prevMatcher.val < -50)
                {
                    _prevMatcher = nodeInsert;
                    _headList1 = _prevMatcher;
                    nodeInsert.next = _matcher;
                }
                else
                {
                    _prevMatcher.next = nodeInsert;
                    nodeInsert.next = _matcher;

                    _prevMatcher = _prevMatcher.next;
                }
            }
            else
            {
                _prevMatcher = _prevMatcher?.next;
                _matcher = _matcher?.next;
            }
        }

        return _headList1;
    }
}