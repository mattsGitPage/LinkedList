using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListCSharp;


namespace TestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListInsertion()
        {
            LinkedList list = new LinkedList();
            Node node = new Node("1");
            list.InsertNode(node);
            Node node1 = new Node("2");
            list.InsertNode(node1);
            Assert.AreEqual("2", list.GetListHead().Data);
        }

        [TestMethod]
        public void TestDeletion()
        {
            LinkedList list = new LinkedList();
            Node node = new Node("1");
            list.InsertNode(node);
            Node node1 = new Node("2");
            list.InsertNode(node1);
            Assert.AreEqual("2", list.GetListHead().Data);
        }
    }
}
