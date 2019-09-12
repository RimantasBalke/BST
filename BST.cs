using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class BST
    {

        private Node root;


        public BST()
        {
        }

        public Node GetRoot()
        {
            return this.root;
        }

        public void Insert(int key)
        {
            root = InsertRec(root, key);
        }

        public Node InsertRec(Node root, int key)
        {

            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else if (key > root.key)
                root.right = InsertRec(root.right, key);

            return root;
        }

        public void Inorder()
        {
            InorderRec(root);
        }

        public void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.left);
                Console.WriteLine(root.key);
                InorderRec(root.right);
            }
        }

        public void DeleteBinarySearchTree()
        {
            this.root = null;
        }

        private  Node MinimumKey(Node curr)
        {
            while (curr.left != null)
            {
                curr = curr.left;
            }
            return curr;
        }

        public void UpdateNode(Node root , int oldKey, int newKey) {
        

            this.DeleteNodeByValue(root, oldKey);

            this.Insert(newKey);

            Console.WriteLine("Tree has been updated");


        }

        public void TraverseRight()
        {
            InorderRec(root.right);
        }

        public void TraverseLeft()
        {
            InorderRec(root.left);
        }


        public Node DeleteNodeByValue(Node root, int deleteValue)
        {
            Node parentNode = null;
            Node currentNode = root;


            
            while (currentNode != null && currentNode.key != deleteValue)
            {
                parentNode = currentNode;

 
                if (deleteValue < currentNode.key)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = currentNode.right;
                }
            }

            if (currentNode == null)
            {
                return root;
            }

            
            if (currentNode.left == null && currentNode.right == null)
            {

                if (currentNode != root)
                {
                    if (parentNode.left == currentNode)
                    {
                        parentNode.left = null;
                    }
                    else
                    {
                        parentNode.right = null;
                    }
                }
               
                else
                {
                    root = null;
                }
            }

           
            else if (currentNode.left != null && currentNode.right != null)
            {
               
                Node successor = MinimumKey(currentNode.right);

                
                int val = successor.key;


                DeleteNodeByValue(root, successor.key);

                
                currentNode.key = val;
            }

            else
            {
               
                Node child = (currentNode.left != null) ? currentNode.left : currentNode.right;

               
                if (currentNode != root)
                {
                    if (currentNode == parentNode.left)
                    {
                        parentNode.left = child;
                    }
                    else
                    {
                        parentNode.right = child;
                    }
                }

               
                else
                {
                    root = child;
                }
            }

            return root;
        }
    }
}
