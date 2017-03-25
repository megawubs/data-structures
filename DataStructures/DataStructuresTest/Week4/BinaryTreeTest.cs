using DataStructures.Structures.Tree;
using DataStructures.Week4;
using NUnit.Framework;

namespace DataStructuresTest.Week4
{
    [TestFixture]
    public class BinaryTreeTest
    {
        [Test]
        public void it_sets_the_root_node_when_root_is_null()
        {
            var tree = new BinaryTree<int>();
            tree.Add(9);

            Assert.AreEqual(9, tree.Root.Element);
        }

        [Test]
        public void it_adds_a_bigger_element_to_the_right()
        {
            var tree = new BinaryTree<int>();
            tree.Add(9);
            tree.Add(10);

            Assert.AreEqual(tree.Root.Right.Element, 10);
        }

        [Test]
        public void it_adds_a_smaller_element_to_the_left()
        {
            var tree = new BinaryTree<int>();
            tree.Add(9);
            tree.Add(8);

            Assert.AreEqual(tree.Root.Left.Element, 8);
        }

        [Test]
        public void it_can_rotate_two_nodes()
        {
            var tree = new BinaryTree<int>();

            tree.Add(9);
            tree.Add(8);
            tree.Add(4);

//            tree.Print();
            tree.Print();
            //    8
            //   / \
            //  4   9
//            Assert.AreEqual(tree.Root.Element, 8);
//            Assert.AreEqual(tree.Root.Left.Element, 4);
//            Assert.AreEqual(tree.Root.Left.Left.Element, 9);
        }
    }
}