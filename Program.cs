using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {

            BST number = new BST();

            number.insert(15);
            number.insert(16);
            number.insert(14);
            number.insert(13);

            
            number.inorder();
            Console.ReadLine();
            number.deleteNode(number.root,10);
            number.updateNode(number.root, 13, 19);
            number.inorder();
            Console.ReadLine();
        }
    }
}
