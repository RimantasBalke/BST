using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Bst number = new Bst();

            number.insert(15);
            number.insert(16);
            number.insert(14);
            number.insert(13);
            Console.WriteLine(number.root.ToString());
            Console.ReadLine();

        }
    }

    class Bst
    {

        public Node root;


        public Bst()
        {
            root = null;
        }

        public void insert(int key)
        {
            root = insertRec(root, key);
        }

        public Node insertRec(Node root, int key)
        {

            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            return root;
        }

        public void inorder()
        {
            inorderRec(root);
        }

        public void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }
    }

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
            return "element" +" "+ right.key +" "+ left.key +" "+ left.left.key;
        }
    }
}