using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListCSharp;

namespace TestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test inserting at the front on the list.
        /// </summary>
        [TestMethod]
        public void TestListInsertionAtHead()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 4; i >= 0; i--)
                list.InsertNodeAtHead(i);

            Assert.AreEqual("0->1->2->3->4", list.ToString());
        }

        /// <summary>
        /// Delete a node that is in the middle of list.
        /// </summary>
        [TestMethod]
        public void TestListDeletion()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 4; i >= 0; i--)
                list.InsertNodeAtHead(i);

            list.DeleteNode(3);

            Assert.AreEqual("0->1->2->4", list.ToString());
        }

        /// <summary>
        /// Delete a node that is at the beginning of the list.
        /// </summary>
        [TestMethod]
        public void TestListDeletionAtBeginning()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 4; i >= 0; i--)
                list.InsertNodeAtHead(i);

            list.DeleteNode(0);

            Assert.AreEqual("1->2->3->4", list.ToString());
        }

        /// <summary>
        /// Delete a node that is at the end of the list
        /// </summary>
        [TestMethod]
        public void TestListDeletionAtEnd()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 4; i >= 0; i--)
                list.InsertNodeAtHead(i);

            list.DeleteNode(4);

            Assert.AreEqual("0->1->2->3", list.ToString());
        }

        /// <summary>
        /// Delete a node that not in the list.
        /// </summary>
        [TestMethod]
        public void TestListDeletionValueNotInList()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 4; i >= 0; i--)
                list.InsertNodeAtHead(i);

            list.DeleteNode(5);

            Assert.AreEqual("0->1->2->3->4", list.ToString());
        }

        /// <summary>
        /// Delete a node in an empty list.
        /// </summary>
        [TestMethod]
        public void TestListDeletionEmptyList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.DeleteNode(5);

            Assert.AreEqual("", list.ToString());
        }

    }
}
