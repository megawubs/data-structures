using System;

namespace DataStructures.Week4
{
    public class TreeNode<T>
    {
        public TreeNode<T> FirstChild;
        public TreeNode<T> NextSibling;

        public T Data;

        public TreeNode(T data)
        {
            Data = data;
        }

        public void PrintPreOrder()
        {
            Console.WriteLine(this);
            FirstChild?.PrintPreOrder();
            NextSibling?.PrintPreOrder();
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        public int GetSize()
        {
            int size = 1;
            if (FirstChild != null) size += FirstChild.GetSize();
            if (NextSibling != null) size += NextSibling.GetSize();
            return size;
        }


        public void Paint()
        {

        }
    }
}