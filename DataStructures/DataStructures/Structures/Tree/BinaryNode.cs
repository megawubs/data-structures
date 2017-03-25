using System;

namespace DataStructures.Structures.Tree
{
    public class BinaryNode<T> where T : IComparable<T>
    {

        public T Element { get; set; }
        public BinaryNode<T> Left { get; set; }
        public BinaryNode<T> Right { get; set; }

        public BinaryNode()
        {

        }

        public BinaryNode(T element, BinaryNode<T> left, BinaryNode<T> right)
        {
            Element = element;
            Left = left;
            Right = right;
        }

        public static int Size(BinaryNode<T> t)
        {
            if (t == null)
            {
                return 0;
            }

            return 1 + Size(t.Left) + Size(t.Right);
        }

        public static int Height(BinaryNode<T> t)
        {
            if (t == null)
            {
                return -1;
            }

            return 1 + Math.Max(Height(t.Left), Height(t.Right));
        }

        public BinaryNode<T> Duplicate()
        {
            var root = new BinaryNode<T>(Element, null, null);
            if (Left != null)
            {
                root.Left = Left;
            }
            if (Right != null)
            {
                root.Right = Right;
            }
            return root;
        }


        public void PrintPreOrder()
        {
            Console.WriteLine(Element.ToString());
            Left?.PrintPreOrder();
            Right?.PrintPreOrder();
        }

        public void PrintPostOrder()
        {
            Left?.PrintPostOrder();
            Right?.PrintPostOrder();
            Console.WriteLine(Element.ToString());
        }

        public void PrintInOrder()
        {
            Left?.PrintInOrder();
            Console.WriteLine(Element.ToString());
            Right?.PrintInOrder();
        }
    }
}