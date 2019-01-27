using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCSharp
{
    public class LinkedList<T> 
    {
        private class Node
        {
            public Node(T Data)
            {
                data = Data;
                next = null;
            } 

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            private T data;
            public T Data { get { return data; } set { data = value; } }
        }

        private Node head;

        public LinkedList()
        {
            head = null;
        }

        /// <summary>
        /// Get the linked list head.
        /// </summary>
        /// <returns></returns>
        public void InsertNodeAtHead(T node)
        {
            Node temp = new Node(node);
            temp.Next = head;
            head = temp;
        }

        

        public void DeleteNode(T node)
        {
            Node previous = null;
            Node temp = head;
            //Check for an empty list.
            if (temp == null)
                return;

            //Check if we are deleting first node in list.
            if (temp.Data.Equals(node))
            {
                head = temp.Next;
                return;
            }
                
            //Iterate over the list looking for the value need. 
            while(temp.Next != null && !temp.Data.Equals(node))
            {
                previous = temp;
                temp = temp.Next;
            }


            if(temp.Data.Equals(node))
                previous.Next = temp.Next;
        }

        public override string ToString()
        {
            Node temp = head;
            string returnValue = string.Empty;
            if (temp != null)
            {
                while (temp.Next != null)
                {
                    returnValue += temp.Data + "->";
                    temp = temp.Next;
                }
                returnValue += temp.Data;
            }
            return returnValue;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
