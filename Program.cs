using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[100];

            Random randNum = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = randNum.Next(0, 1000);
            }

            BST bts = new BST();

            foreach (int d in data)
            {
                bts.Insert(d);
            }

            bts.Inorder();
            Console.WriteLine("Root element is :" + bts.GetRoot().key);
            Console.WriteLine("Press any key to traverse left");
            Console.ReadLine();
            bts.TraverseLeft();
            Console.WriteLine("Press any key to traverse right");
            Console.ReadLine();
            bts.TraverseRight();
            Console.WriteLine("Write node value which you want to delete");
            string number= Console.ReadLine();
            int value = Int32.Parse(number);
            bts.DeleteNodeByValue(bts.GetRoot(),value);
            bts.Inorder();
            Console.WriteLine("Press any key to exit");
            bts.DeleteBinarySearchTree();
            Console.ReadLine();
        }
    }
}
