using System;
using DataStructures.Structures.Tree;

namespace DataStructures.Week4
{
    public class Runner : IRunner
    {
        public void Run()
        {
            BinaryTreeTryout();
        }

        private void BinaryTreeTryout()
        {
            var tree = new BinaryTree<int>();

            tree.Add(9);
            tree.Add(8);
            tree.Add(4);
            tree.Add(5);
            tree.Add(15);
            tree.Add(10);
//            tree.Add(3);
            tree.Print();
//            tree.Root.PrintInOrder();
        }

        private static void GeneralTreeTryout()
        {
            var a = new TreeNode<string>("A");
            var b = new TreeNode<string>("B");
            var c = new TreeNode<string>("C");
            var d = new TreeNode<string>("D");
            var e = new TreeNode<string>("E");
            var f = new TreeNode<string>("F");
            var g = new TreeNode<string>("G");
            var h = new TreeNode<string>("H");
            var i = new TreeNode<string>("I");
            var j = new TreeNode<string>("j");
            var k = new TreeNode<string>("K");

            var tree = new GeneralTree<string>();
            tree.Root = a;

            a.FirstChild = b;

            b.FirstChild = f;
            f.NextSibling = g;

            b.NextSibling = c;

            c.NextSibling = d;

            d.FirstChild = h;
            d.NextSibling = e;

            e.FirstChild = i;

            i.NextSibling = j;

            j.FirstChild = k;

            tree.PrintPreOrder();
            Console.WriteLine(tree.GetSize());
        }
    }
}