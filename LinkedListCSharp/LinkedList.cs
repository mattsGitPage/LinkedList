using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCSharp
{
    public class LinkedList
    {
        public LinkedList() { }

        private Node Head;
        private Node Tail;

        /// <summary>
        /// Get the linked list head.
        /// </summary>
        /// <returns></returns>
        public Node GetListHead()
        {
            return Head;
        }

        /// <summary>
        /// Get the last element in the list.
        /// </summary>
        /// <returns>Tail of the list.</returns>
        public Node GetListTail()
        {
            Node temp = Head;
            //Check for an empty list.
            if (temp == null)
                return null;

            //Check for a single item in the list.
            if (temp.Next == null)
                return Head;

            //Iterate to the last item in the list. 
            while (temp.Next != null)
                temp = temp.Next;

            return temp;
        }

        /// <summary>
        /// Insert node at the front of list.
        /// </summary>
        /// <param name="node">Node to insert.</param>
        public void InsertNode(Node node)
        {
            Node temp = Head;
            Head = node;
            Head.Next = temp;
        }

        public void DeleteNode(Node node)
        {

        }
    }
}
