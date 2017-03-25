using DataStructures.Week4;

namespace DataStructures.Structures.Tree
{
    public class GeneralTree<T>
    {
        public TreeNode<T> Root;

        public void PrintPreOrder()
        {
            Root.PrintPreOrder();
        }

        public int GetSize()
        {
            return Root.GetSize();
        }

        public void PaintTree()
        {
            var node = Root;
            node.Paint();
        }
    }
}