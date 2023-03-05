using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    public class Solution
    {

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
 
            if (list1 is null) return list2;
            else if (list2 is null) return list1;

            ListNode dummy = new ListNode(), point = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    point.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    point.next = list2;
                    list2 = list2.next;
                }

                point = point.next;
            }

            if (list1 != null)
                point.next = list1;

            if (list2 != null)
                point.next = list2;

            return dummy.next;
        }

    }
}
