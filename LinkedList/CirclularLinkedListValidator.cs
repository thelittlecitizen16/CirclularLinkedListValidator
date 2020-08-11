using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class CirclularLinkedListValidator 
    {
        public bool IsCircular<T>(LinkedList<T> linkedList)
        {

            if (linkedList.Count == 0)
            {
                return false;
            }

            LinkedListNode<T> node = linkedList.First;


            if (linkedList.Count == 1)
            {
                if (node.Next == null)
                {
                    return false;
                }
            }

            int count = 1;

            while (count < linkedList.Count())
            {
                node = node.Next;
                count++;
            }

            return !(node == linkedList.Last);        }
    }
}
