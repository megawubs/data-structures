using System;

namespace DataStructures.Structures.Tree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public BinaryNode<T> Root { get; private set; }

        public void Add(T d)
        {
            if (Root == null)
            {
                Root = new BinaryNode<T>(d, null, null);
            }
            else
            {
                var node = Root;
                while (true)
                {
                    var compare = node.Element.CompareTo(d);
                    //its bigger than the current node
                    if (compare == -1)
                    {
                        if (node.Right != null)
                        {
                            node = node.Right;
                        }
                        else
                        {
                            node.Right = new BinaryNode<T>(d, null, null);
                            break;
                        }

                    }

                    //it's smaller than the current node
                    if (compare == 1)
                    {
                        if (node.Left != null)
                        {
                            node = node.Left;
                        }
                        else
                        {
                            node.Left = new BinaryNode<T>(d, null, null);
                            break;
                        }
                    }
                }
            }
        }

        public static void Rotate(BinaryNode<T> parent, BinaryNode<T> child)
        {
            //step 1
            var value = parent.Element;
            parent.Element = child.Element;
            child.Element = value;

            //step 2
            var temp1 = parent.Left;
            parent.Left = child.Left;
            var temp2 = parent.Right;
            parent.Right = temp1;
            child.Right = temp2;
            child.Left = null;
        }

        public void Print()
        {
            Console.Clear();
            var node = Root;
            Print(node, 0, BinaryNode<T>.Height(node) * 2);
            Console.SetCursorPosition(0, BinaryNode<T>.Height(node) * 2 + 1);
        }

        public void Print(BinaryNode<T> node, int initalHeight = 0, int left = 0)
        {
            var height = initalHeight;
            Console.SetCursorPosition(left, height);
            Console.Write(node.Element.ToString());

            //right
            if (node.Right != null)
            {
                Console.SetCursorPosition(left + node.Element.ToString().Length, height + 1);
                Console.Write('\\');
                Print(node.Right, height + 2, left + 2);
            }
            //left
            if (node.Left != null)
            {
                Console.SetCursorPosition(left - 1, height + 1);
                Console.Write('/');
                Print(node.Left, height + 2, left - 2);
            }
            Console.ReadKey();
        }
    }
}