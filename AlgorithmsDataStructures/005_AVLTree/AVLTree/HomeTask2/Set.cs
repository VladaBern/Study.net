using System.Collections.Generic;

namespace HomeTask2
{
    internal class Set
    {
        private AVLTree<int> tree = new AVLTree<int>();

        public void Add(int value)
        {
            tree.Add(value);
        } 

        public bool Remove(int value)
        {
            return tree.Remove(value);
        }

        public IEnumerable<int> SymmetricDifference(Set other)
        {
            AVLTree<int> result = new AVLTree<int>();

            foreach (var node in other.tree)
            {
                if (!tree.Contains(node))
                    result.Add(node);
            }

            foreach (var node in tree)
            {
                if (!other.tree.Contains(node))
                    result.Add(node);
            }

            return result;
        }
    }
}
