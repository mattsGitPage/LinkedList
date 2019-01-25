using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCSharp
{
    public class Node
    {
        public Node(object data) => (Data) = (data);
        public object Data { get; set; }
        public Node Next { get; set; }
    }
}
