using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class BST
    {

        public Node root;


        public BST()
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

        public void deleteBinarySearchTree()
        {
            this.root = null;
        }

        public static Node minimumKey(Node curr)
        {
            while (curr.left != null)
            {
                curr = curr.left;
            }
            return curr;
        }

        public void updateNode(Node root , int oldKey, int newKey) {
        

            this.deleteNode(root, oldKey);

            this.insert(newKey);

            Console.WriteLine("Tree has been updated");


        }

        public void traverseRight(Node root)
        {

        }


        public Node deleteNode(Node root, int deleteValue)
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
               
                Node successor = minimumKey(currentNode.right);

                
                int val = successor.key;

               
                deleteNode(root, successor.key);

                
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
