using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
        public override string ToString()
        {
            return "element" + " " + right.key + " " + left.key + " " + left.left.key;
        }
    }
}
